int circleX = 0;
  int circleY = 0;
  int circle1X = 70;
  int circle1Y = 70;
void setup() {
  size(480,270);
}

void draw() {
  background (255);
  stroke(0);
 


// SIDE PROJECT
fill(mouseX/2, mouseY/2);
ellipse(circleX,50,50,50);

circleX = circleX +1;


circle1X = circle1X +1;
}
