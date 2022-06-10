const int ledCount = 10;    // the number of LEDs in the bar graph
int ledPins[] = { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };  // an array of pin numbers to which LEDs are attached
void setup() {
for (int i = 0; i < ledCount; i++) {    // loop over the pin array and set them all to output:
    pinMode(ledPins[i], OUTPUT);
  }
}
void loop() { 
  for (int i = 0; i < ledCount; i++) {    // the ith LED of LED bar graph will light up in turn
    barGraphDisplay(i);
  }
 for (int i = ledCount; i > 0; i--) {     // makes the "i"th LED of LED bar graph bright in reverse order
    barGraphDisplay(i - 1);
  }
}
void barGraphDisplay(int ledOn) {
for (int i = 0; i < ledCount; i++) {    // make the "ledOn"th LED of LED bar graph on and the others off
    if (i == ledOn)
      digitalWrite(ledPins[i], HIGH);
    else
      digitalWrite(ledPins[i], LOW);
  }
  delay(600);
}
