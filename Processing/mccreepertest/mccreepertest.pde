void setup(){
size(1000,1000);
background(0,0,300);
rectMode(CENTER);
}
   void draw(){
     rectMode(CENTER);
  int a = -125;
  int b = 225;
  //HEAD
fill (0,190,0);
rect(225+b,225-a,100,100);
fill(0);
rect(200+b,215-a,26.66,26.66);
rect(250+b,215-a,26.66,26.66); 
rect(225+b,246-a,23.33,35); 
rect(243+b,258-a,11.66,34);
rect(207+b,258-a,11.66,34); 
//BODY
fill (0,190,0);
rect(225+b,360-a,90,170);
rect(200+b,455-a,50,70);
rect(250+b,455-a,50,70);
fill (0,100,0);
rect(250+b,485-a,50,10);
rect(200+b,485-a,50,10);
  

}
