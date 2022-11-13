int x = 0;
int y = 0;
int speed = 2;
int path = 1;

void setup() {
  size(200,200);
  smooth();
}

void draw() {
  background(255);
  fill(0);
  rect(x, y, 10, 10);
  
  
  
  ///////////////////////////////////////////////
  
  if (path == 1) {
    x = x + speed;
    
  }
  if (x > 190) {
    x = 190;
    path = 2;
    
  }
  
  
  else if (path == 2) {
     y = y + speed;
   
   
  }
  if (y > 190) {
     y = 190;
     path = 3;
  }
  else if (path == 3) {
        x = x - speed;
  }
  if (x < 0) {
    x = 0;
    path = 4;

}   
  else if (path == 4) {
        y = y - speed;
  }
  if (x == 0 && y == 0) {
  x = 0;
  path = 1;
}
}
