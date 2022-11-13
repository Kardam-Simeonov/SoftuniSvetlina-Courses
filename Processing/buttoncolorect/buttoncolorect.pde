
boolean button = false;    //DEFAULT VALUE OF BOOLEAN IS FALSE
int r = 255;
void setup () {
  size (500, 500);
}

void draw () {
  background (255);

  if ((mouseX > 200) && (mouseX < 275) && (mouseY > 200) && (mouseY < 275) && (mousePressed)) {
    button = true;
  } else {
    button = false;
  }

  if (button) {
    fill (r, 0, 255);
    r = r -1;
    
  
  } else {
    fill (255);
    r = 255;
  }

  rectMode (CENTER);
  rect (250, 250, 75, 75);
  println ("button=", button);
  println ("r=", r);
}
