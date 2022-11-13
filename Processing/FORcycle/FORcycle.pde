void setup(){
  size (200,200);
  background(255);
}

void draw() {
  int counter = 0;
  for (int y = 0; y < 160; y +=10) { // first value is from where, second to where and 3rd is how
    counter++;
    stroke (255,0,0);
    line (0,y,200,y);
    println(counter);
    println("y =  " + y);
    
  }
}
