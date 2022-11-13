float w = 150;


void setup(){
  size (200,200);
  background(255);
}

void draw() {
  while(w > 0){
  stroke(0);
  fill(w);
  ellipseMode(CENTER);
  ellipse(100,100,w,w);
  
  w = w - 20;
  }
}
