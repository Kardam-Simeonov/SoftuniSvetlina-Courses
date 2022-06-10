#include <LiquidCrystal.h> 
 
// initialize the library with the numbers of the interface pins 
LiquidCrystal lcd(12, 11, 5, 4, 3, 2); 
 void setup() { 
  lcd.begin(16, 2); 
  lcd.print("Jihad Bomb"); 
}  void loop() { 
  // set the cursor to column 0, line 1 
    lcd.setCursor(0, 1); 
    lcd.print(" ͡ ͜ʖ ͡° "); 
  //for(int i = 30; i > 0; i--){
    //lcd.scrollDisplayLeft();
    //lcd.print(i);
    //delay(500);
    //lcd.clear();
    //delay(100);
  }
   
