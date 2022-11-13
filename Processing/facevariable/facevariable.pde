void setup() {
  size(720, 400);
  background(255);
  stroke(100);
  
  int a = 50;    //MOVES THE FIGURE X WAYS
  int b = 120;    //MOVES THE FIGURE Y WAYS
  int c = 180;    //CHANGES THE WIDTH OF THE FIGURE
  
  line(a, b , a + c, b);
  line(a, b + 10, a + c, b + 10);
  line(a, b + 20, a + c, b + 20);
  line(a, b + 30, a + c, b + 30);
   
   a = a + c;
   b = height - b;
   
  line(a, b, a+c, b);
  line(a, b+10, a+c, b+10);
  line(a, b+20, a+c, b+20);
  line(a, b+30, a+c, b+30);
  
  b = height + b;
  a = a + c ;
  
 line(a, b, a+c, b);
  line(a, b+10, a+c, b+10);
  line(a, b+20, a+c, b+20);                    
  line(a, b+30, a+c, b+30);
  
  println(a, b, c);
  
  
 
}
