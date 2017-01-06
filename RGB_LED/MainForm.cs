using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_LED
{
    public partial class MainForm : Form
    {
        private enum ArduinoStatus
        {
            Connected,
            Connecting,
            Disconnected
        }

        private SerialPort _arduinoPort;
        private ArduinoStatus _status;
        private int _count = 8;
        private int _size = 25;
        private Bitmap _image;
        private bool[,] _pixels;

        //fonts
        private FontFamily _pixelFontFamily;

        public MainForm()
        {
            InitializeComponent();
            cbAvailablePorts.Items.AddRange(SerialPort.GetPortNames());
            cbAvailablePorts.SelectedIndex = 0;
            _status = ArduinoStatus.Disconnected;
            _image = new Bitmap(pbGrid.Size.Width, pbGrid.Size.Height);
            pbGrid.Image = _image;
            _pixels = new bool[_count, _count];

        }

        #region Event Handlers

        private void btConnect_Click(object sender, EventArgs e)
        {
            _status = ArduinoStatus.Connecting;
            UpdateFormByStatus();
            _arduinoPort = new SerialPort(cbAvailablePorts.SelectedItem.ToString());
            try
            {
                _arduinoPort.Open();
                _status = ArduinoStatus.Connected;
                UpdateFormByStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lbStatus.Text = "Status: Error";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_status == ArduinoStatus.Connected)
            {
                _arduinoPort.Close();
            }
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                _arduinoPort.Close();
                _status = ArduinoStatus.Disconnected;
                UpdateFormByStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lbStatus.Text = "Status: Error";
            }
        }


        #endregion

        #region Private Methods

        private void UpdateFormByStatus()
        {
            switch (_status)
            {
                case ArduinoStatus.Connected:
                    lbStatus.Text = "Status: Successfully connected";
                    btConnect.Enabled = false;
                    btDisconnect.Enabled = true;
                    break;

                case ArduinoStatus.Connecting:
                    lbStatus.Text = "Status: Connecting";
                    break;

                case ArduinoStatus.Disconnected:
                    lbStatus.Text = "Status: Disconnected";
                    btConnect.Enabled = true;
                    btDisconnect.Enabled = false;
                    break;
            }
        }



        private void SendToArduino(byte r, byte g, byte b)
        {
            byte[] buffer = new byte[3];
            buffer[0] = r;
            buffer[1] = g;
            buffer[2] = b;
            _arduinoPort.Write(buffer, 0, 3);
        }


        #endregion

        private void pbGrid_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                pbGrid.BackColor = colorDialog1.Color;
                SendToArduino(colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            }
        }
    }
}
