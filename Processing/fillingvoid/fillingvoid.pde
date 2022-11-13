int a = 299;
void setup() {
  background (0);
  size ( 500,300);
  stroke(255);
  strokeWeight(10);
  frameRate(30);
  
 
}

void draw(){
  a = a - 1;
  line(0, a, 500, a);
  

  
}
