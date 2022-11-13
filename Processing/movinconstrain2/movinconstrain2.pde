float mx = 0;
void setup() {
  size (400,400);
}

void draw() {
  background (204);
  //float mx = constrain(mouseX,30,70);
   mx = constrain(mx,30,190);
  println("mx: " + mx);
  println(mouseX);
  //rect (mx-10,40,20,20);
  rect(mx,40,20,20);
  mx++;
}
