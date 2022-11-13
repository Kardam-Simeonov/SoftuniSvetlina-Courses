boolean button = false;

void setup () {
  size (200,200);
   background (0);
}

void draw () {
  if (button) {               //this means that button equals true
    background (255);
     stroke (0);
  } else {                        // in other words if button equals false
    background (0);
    stroke (255);
  }
  
  fill (252,3,19);
  rectMode (CENTER);
  rect (width/2, height/2, 50,50);
}

void mousePressed () {
  if ((mouseX > 75) && (mouseX < 125) && (mouseY > 75) && (mouseY < 125)) {
    
    button = !button;   //this means that buttons value is changed (from true to false or from false to true)
    
  }
  
}
