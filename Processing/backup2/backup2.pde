void setup(){
size(1000,1000);


}

void draw(){
  int a = 0;
  int b = 0;
  rectMode(CENTER);
  background(200,200,255);
  
  //HEAD
  
fill (0,190,0);
rect(225-a,225-b,100,100);
fill(0);
rect(200-a,215-b,26.66,26.66);
rect(250-a,215-b,26.66,26.66); 
rect(225-a,246-b,23.33,35); 
rect(243-a,258-b,11.66,34);
rect(207-a,258-b,11.66,34); 


//BODY

fill (0,190,0);
rect(225-a,360-b,90,170);
rect(200-a,455-b,50,70);
rect(250-a,455-b,50,70);
fill (0,100,0);
rect(250-a,485-b,50,10);
rect(200-a,485-b,50,10);






}
