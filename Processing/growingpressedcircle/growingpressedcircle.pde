boolean button = false;
int x = 0;
int y = 0;
 
void setup(){
  size(500,500);
}
void draw () {
  if (button) {
    x = x + 1;
     y = y + 1;
  }
  else {
    x = x;
    y = y;
  }
  background(255);
  fill(0,0,255);
  ellipse(250,250,x,y);
}
   void mousePressed() {
     button = !button;
   }
     
  
