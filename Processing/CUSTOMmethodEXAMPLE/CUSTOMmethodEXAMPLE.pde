int x = 0;
int speed = 2;

void setup() {
  size(200,200);
  smooth();
}

void draw() {
  background(255);
  move();     // we use the function move
  bounce();   // we use the function bounce
  display();     // we use the function display
}

void move () {
  x += speed;  // change the location of x by speed
}

void bounce() {
  //if we reach an edge then reverse the speed
  if ((x > width) || (x < 0)) {
    speed *= -1;
  }
}

void display(){
// displays the ball
   stroke(0,0,255);
   fill(255,0,0);
   ellipse (x,100,32,32);
   }
