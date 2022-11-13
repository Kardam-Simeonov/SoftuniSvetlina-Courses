void setup() {
  size (500,500);
}

void draw () {
  background (255);
  stroke ( 100);
  line (250, 0, 250, 500);
    line (0,250, 500, 250);
  
  if (mouseX > width/2 && mouseY > height/2) {
    
    fill (234,17,17);
    rect (width/2, height/2, width/2, height/2);
  }
  if (mouseX > width/2 && mouseY < height/2) {
    
    fill (234,234,17);
    rect (width/2, 0, width/2, height/2);
  }
  if (mouseX < width/2 && mouseY < height/2) {
    
    fill (0,234,234);
    rect (0, 0, width/2, height/2);
  }
  if (mouseX < width/2 && mouseY > height/2) {
    
    fill (0,233,0);
    rect (0, height/2, width/2, height/2);
  }
  
} 
