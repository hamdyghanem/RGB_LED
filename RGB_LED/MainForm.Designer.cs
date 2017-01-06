namespace RGB_LED
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbAvailablePorts = new System.Windows.Forms.ComboBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.pbGrid = new System.Windows.Forms.PictureBox();
            this.lbCllick = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAvailablePorts
            // 
            this.cbAvailablePorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAvailablePorts.FormattingEnabled = true;
            this.cbAvailablePorts.Location = new System.Drawing.Point(12, 12);
            this.cbAvailablePorts.Name = "cbAvailablePorts";
            this.cbAvailablePorts.Size = new System.Drawing.Size(121, 21);
            this.cbAvailablePorts.TabIndex = 0;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(153, 10);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(119, 23);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(12, 46);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(109, 13);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Status: Disconnected";
            // 
            // btDisconnect
            // 
            this.btDisconnect.Enabled = false;
            this.btDisconnect.Location = new System.Drawing.Point(293, 10);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(119, 23);
            this.btDisconnect.TabIndex = 4;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // pbGrid
            // 
            this.pbGrid.BackColor = System.Drawing.Color.White;
            this.pbGrid.Location = new System.Drawing.Point(15, 88);
            this.pbGrid.Name = "pbGrid";
            this.pbGrid.Size = new System.Drawing.Size(492, 281);
            this.pbGrid.TabIndex = 8;
            this.pbGrid.TabStop = false;
            this.pbGrid.Click += new System.EventHandler(this.pbGrid_Click);
            // 
            // lbCllick
            // 
            this.lbCllick.AutoSize = true;
            this.lbCllick.Location = new System.Drawing.Point(12, 68);
            this.lbCllick.Name = "lbCllick";
            this.lbCllick.Size = new System.Drawing.Size(98, 13);
            this.lbCllick.TabIndex = 14;
            this.lbCllick.Text = "Click to select color";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 452);
            this.Controls.Add(this.lbCllick);
            this.Controls.Add(this.pbGrid);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.cbAvailablePorts);
            this.Name = "MainForm";
            this.Text = "RGB LED Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAvailablePorts;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.PictureBox pbGrid;
        private System.Windows.Forms.Label lbCllick;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

