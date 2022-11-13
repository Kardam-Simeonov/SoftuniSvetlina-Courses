boolean button = false;

void setup () {
  size (200,200);
   background (0);
   stroke(255);
   rectMode(CENTER);
}

void draw () {
  if (button == true) {               //this means that button equals true
    background (255);
     stroke (0);
     fill (200, 100,100);
     rect (100,100,100,100);
     fill (100, 50,50);
     rect (100,100,150,150);
  } else
        {
     background (0);
     fill (200,0,0);
     rect (100,100,100,100);
     fill (100,50,50);
     rect (100,100,150,150);
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
