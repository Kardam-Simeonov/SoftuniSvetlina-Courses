void setup() {
  println("executed");
  size(400,400);
}

void draw(){
  
}
  
  void mousePressed(){
    stroke(0);
    fill(255);
    rectMode(CENTER);
    rect(mouseX,mouseY,16,16);
    println("REGISTERED");
     println("pos");
    println(mouseX);
     println(mouseY);
    println("0101001001000100100010010");
  }
  
  void keyPressed() {
    println("key registered");
    println("CANVAS CLEANED");
    background(0);}
