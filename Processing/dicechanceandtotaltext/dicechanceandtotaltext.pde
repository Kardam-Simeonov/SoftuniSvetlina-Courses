int chance = 0;
int total = 0;
String points = "POINTS:" + total;
String dice = "DICE:";

void setup() {
  size(500,500);
}
void draw(){
  if (total >= 30) {
     text("YOU WON!", 255,450);
     background(0,255,0);
     chance = 0;                      // PROBLEM : the text goes away after a sec, included a background change as a replacement for better user feedback
     total = 0;
   } else {
     background(0);
  textSize(40);
  text( points + total, 100,100);
  text( dice + chance, 300,200);
   }
  
  
}
void mousePressed(){
   chance = int (random(1,6));
   if (chance == 6) {
      total = total *2;
   }
   else if (total == 13){
     total = total-5;
   }
   else {
     total = total + chance;
   }
   
  
}
