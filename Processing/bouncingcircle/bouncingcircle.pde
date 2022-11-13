float y = 0;
float x = 0;
float speedy = 1;
float speedx = 2;

void setup(){
  size (200,200);
  smooth();
}

void draw() {
  background (255);
  
  if ((y <0) || (y > height)){
    speedy = speedy * -1.1;
  }
  if ((x <0) || (x > width)){
    speedx = speedx * -1.1;
  }
  
  
  y = y + speedy;
  x = x + speedx;
  fill (255,0,255);
  ellipse (x,y,30,30);
}
