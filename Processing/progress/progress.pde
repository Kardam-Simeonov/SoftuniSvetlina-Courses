float a = 250;
float b = 250 ;

void setup() {
  size(500,500);
  background(0);
}
void draw(){
    stroke (255);
  point(a, b);
  a = a + random(-10,10);
  b = b + random(-10,10);
}
