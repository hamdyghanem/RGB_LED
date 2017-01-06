//by Hamdy Ghanem

// Define Pins
#define RED 9
#define GREEN 10
#define BLUE 11

#define delayTime 10 // fading time between colors

// cursor position:


void setup()
{
pinMode(RED, OUTPUT);
pinMode(GREEN, OUTPUT);
pinMode(BLUE, OUTPUT);
digitalWrite(RED, HIGH);
digitalWrite(GREEN, HIGH);
digitalWrite(BLUE, HIGH);
//
Serial.begin(9600);
}

// define variables
int redValue;
int greenValue;
int blueValue;


// main loop
void loop()
{
 
    readInput();

  delay(100);
}

void readInput() {
  if (Serial.available() > 2) {  
    redValue = Serial.read();
    greenValue = Serial.read();
    blueValue = Serial.read();
 
    analogWrite(RED, redValue);
    analogWrite(GREEN, greenValue);
    analogWrite(BLUE, blueValue);
  
  }
}

