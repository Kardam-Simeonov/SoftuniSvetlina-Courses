float xpos = 36;
float ypos = 250;
PImage shrek;
void setup () {
  size( 500, 500);
  shrek = loadImage ("Shrek_(character).png")
  
  
  
}
void draw () {
 background (255);
  
  rectMode(CENTER);
  image (shrek,xpos,ypos,75,75);
 
  
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
       
       } 
  
    //STATIONARYY
  } else {
    xpos = xpos + 0;
  }
}
  
  
