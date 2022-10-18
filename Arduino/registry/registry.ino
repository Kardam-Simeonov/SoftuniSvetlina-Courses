int latchPin = 12;          // Pin connected to ST_CP of 74HC595（Pin12）
int clockPin = 13;          // Pin connected to SH_CP of 74HC595（Pin11）
int dataPin = 11;           // Pin connected to DS of 74HC595（Pin14）
void setup() {     // set pins to output 
  pinMode(latchPin, OUTPUT);
  pinMode(clockPin, OUTPUT);
  pinMode(dataPin, OUTPUT);
}
void loop() {   // Define a one-byte variable to use the 8 bits to represent the state of 8 LEDs of LED bar graph.
                    // This variable is assigned to 0x01, that is binary 00000001, which indicates only one LED light on.
  byte x = 0x01;
  for (int j = 0; j < 8; j++) {
    digitalWrite(latchPin, LOW);   // Output low level to latchPin    
    shiftOut(dataPin, clockPin, LSBFIRST, x);  // Send serial data to 74HC595
    digitalWrite(latchPin, HIGH);  // Output high level to latchPin, and 74HC595 will update the data to the parallel output port.
    x <<= 1;   // make the variable move one bit to left once, then the bright LED move one step to the left once.
    delay(100);
  }
}   