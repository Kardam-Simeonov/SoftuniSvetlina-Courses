
int ledPin3 = 9; 
int ledPin1 = 5;
int ledPin2 = 6;
int ledPin4 = 10;  // LED connected to digital pin 9

void setup() {
  // nothing happens in setup
}

void loop() {
  // fade in from min to max in increments of 5 points:
  for (int fadeValue = 0 ; fadeValue <= 255; fadeValue += 5) {
    // sets the value (range from 0 to 255):
    analogWrite(ledPin1, fadeValue);
    analogWrite(ledPin2, fadeValue);
    analogWrite(ledPin3, fadeValue);
    analogWrite(ledPin4, fadeValue);
    // wait for 30 milliseconds to see the dimming effect
    delay(60);
  }

  // fade out from max to min in increments of 5 points:
  for (int fadeValue = 255 ; fadeValue >= 0; fadeValue -= 5) {
    // sets the value (range from 0 to 255):
    analogWrite(ledPin1, fadeValue);
    analogWrite(ledPin2, fadeValue);
    analogWrite(ledPin3, fadeValue);
    analogWrite(ledPin4, fadeValue);
    // wait for 30 milliseconds to see the dimming effect
    delay(60);
  }
  
}
