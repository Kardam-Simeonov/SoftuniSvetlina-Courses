void setup() {
  size(500,500);
}

void draw () {
  if ((mouseX > 100) && (mouseX < 150)) {
    fill (255,0,0);
    rect (100,100,50,50);
  }
  else if (( mouseX > 250) && (mouseX < 350)) {
    fill(0,255,0);
    ellipse (300,300,60,60);
  }
  else {
    background(255);
  }
}
