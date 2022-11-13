void setup() {
  size (700,200);
  stroke(0);
  
  rectMode (CORNER);

  int b = 0;
}

void draw() {
  background (255);
 line (100, 0,100, 150);
  line (200, 0,200, 150);
   line (300, 0,300, 150);
    line (400, 0,400, 150);
     line (500, 0,500, 150);
      line (600, 0,600, 150);
 line (0, 150, 700, 150);
}

void mousePressed() {
  int b = int(random(1,8));
   if ((mouseX > 0) && (mouseX < 700) && (mouseY > 150) && (mouseY < 200) && (b == 1)) {
     println("monday");
     fill(0);
     rect(0,0,100,150);
   }
   else if ((mouseX > 0) && (mouseX < 700) && (mouseY > 150) && (mouseY < 200) && (b == 2)) {
     println ("tuesday");
     fill(0);
     rect(100,0,100,150);
   }
   else if ((mouseX > 0) && (mouseX < 700) && (mouseY > 150) && (mouseY < 200) && ( b== 3)) {
     println ("wednesday");
     fill(0);
     rect(200,0,100,150);
   }
   else if ((mouseX > 0) && (mouseX < 700) && (mouseY > 150) && (mouseY < 200) && ( b == 4)) {
     println ("thursday");
     fill(0);
     rect(300,0,100,150);
   }
   else if  ((mouseX > 0) && (mouseX < 700) && (mouseY > 150) && (mouseY < 200) && ( b == 5)) {
     println ("friday");
     fill(0);
     rect(400,0,100,150);
   }
    else if ((mouseX > 0) && (mouseX < 700) && (mouseY > 150) && (mouseY < 200) && ( b == 6)) {
     println ("saturday"); 
     fill(0);
     rect(500,0,100,150);
   }
    else if ((mouseX > 0) && (mouseX < 700) && (mouseY > 150) && (mouseY < 200) && ( b == 7)) {
     println ("sunday"); 
     fill(0);
     rect(600,0,100,150);
   }
   else { println ("");
   }
}

     






   
  
