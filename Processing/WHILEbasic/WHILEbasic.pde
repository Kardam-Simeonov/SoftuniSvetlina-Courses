int y = 5;

void setup() {
  size (300,300);
  background (252,8,8);
}

void draw () {
  
  while(y < 290){
  rectMode (CENTER);
  rect (150,y,200,10);
  y = y + 20;
  }
}
