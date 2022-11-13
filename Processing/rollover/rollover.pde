void setup(){
  size(600,600);
  
}
void draw(){
  background(255);
  line(200,0,200,600);
    line(400,0,400,600);
    line(0,200,600,200);
    line(0,400,600,400);
    if ((mouseX > 0) && (mouseX < 200) && (mouseY > 0) && (mouseY < 200)) {
      
  fill(0);
  rect(0,0,200,200);
} else if ((mouseX > 200) && (mouseX < 400) && (mouseY > 0) && (mouseY < 200)) {
  
  fill(0);
  rect(200,0,200,200);
} else if ((mouseX > 400) && (mouseX < 600) && (mouseY > 0) && (mouseY < 200)) {
  
  fill(0);
  rect(400,0,200,200);
}  else if ((mouseX > 0) && (mouseX < 200) && (mouseY > 200) && (mouseY < 400)) {
  
  fill(0);
  rect(0,200,200,200);
} else if ((mouseX > 200) && (mouseX < 400) && (mouseY > 200) && (mouseY < 400)) {
  
  fill(0);
  rect(200,200,200,200);
} else if ((mouseX > 400) && (mouseX < 600) && (mouseY > 200) && (mouseY < 400)) {
 
  fill(0);
  rect(400,200,200,200);
} else if ((mouseX > 0) && (mouseX < 200) && (mouseY > 400) && (mouseY < 600)) {

  fill(0);
  rect(0,400,200,200);
} else if ((mouseX > 200) && (mouseX < 400) && (mouseY > 400) && (mouseY < 600)) {
  
  fill(0);
  rect(200,400,200,200);
} else if ((mouseX > 400) && (mouseX < 600) && (mouseY > 400) && (mouseY < 600)) {
  
  fill(0);
  rect(400,400,200,200);
} 

else {
 } }
