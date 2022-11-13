void setup() {
  size(1000,1000);
}
void draw() {
  if (mouseX < width/2){
    background(255,0,0);
  } 
  else if (mouseX > height/2) {
    background(0,255,255);
  }
}
