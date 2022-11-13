float xpos = 36;
float ypos = 250;
float r = 0;
float g = 0;
float b = 0;

void setup () {
  size( 500, 500);
  
  
  
}
void draw () {
 background (255);
  
  rectMode(CENTER);
  fill (r,g,b);
  rect (xpos, ypos, 75,75);
  
    println("xpos=", xpos);
    
    // RIGHT
    
    if (key == CODED) {
    if (keyCode == RIGHT) {
      xpos = xpos + 1;
      xpos = constrain (xpos,36, 462);
      //LEFT
    } else if (keyCode == LEFT) {
       xpos = xpos - 1;
      xpos = constrain (xpos,36, 462);
      
      //UP
    } else if (keyCode == UP) {
       ypos = ypos - 1;
      ypos = constrain (ypos,38, 462);
      //DOWN
    } else if (keyCode == DOWN) {
       ypos = ypos + 1;
      ypos = constrain (ypos,38, 462);
    } 
    
    //STOP
    else if (keyCode == SHIFT) {
       xpos = xpos - 0;
       ypos = ypos - 0;
       //COLOR
       }  else if (keyCode == CONTROL) {
         r = random(255);
                  g = random(255);
                           b = random(255);
       } 
  
    //STATIONARYY
  } else {
    xpos = xpos + 0;
  }
}
  
  
