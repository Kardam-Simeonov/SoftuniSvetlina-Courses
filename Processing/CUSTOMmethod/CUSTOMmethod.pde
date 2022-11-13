void setup() {
  size (400,400);
  smooth();
}

void draw() {
  background (255);
  Greencircles();
}

void Greencircles(){
  fill (0,255,0);
  ellipse (200,200,200,200);
  fill (0,200,0);
  ellipse (200,200,150,150);
  fill (0,150,0);
  ellipse (200,200,100,100);
  fill (0,100,0);
  ellipse (200,200,50,50);
}
