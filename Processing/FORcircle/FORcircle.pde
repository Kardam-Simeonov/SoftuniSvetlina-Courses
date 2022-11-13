void setup() {
  size(200,200);
  background(255);
}


void draw () {
  
  for (int w = 150; w > 0;  w-=20) {
    stroke (0);
    fill (w);
    ellipseMode(CENTER);
    ellipse (100,100,w,w);
  }
}
