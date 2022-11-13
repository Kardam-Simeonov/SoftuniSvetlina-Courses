void setup() {
  size(720,400);
  background(255);
  
  int myVariable1 = 20;
  int myVariable2 = 30;
  int myVariable3 = 40;
  
  println("var1: " + myVariable1);
  println("var2: " + myVariable2);
  println("var3: " + myVariable3);
  
  myVariable1 = myVariable1 +5;
  myVariable2 = myVariable2 +5;
  myVariable3 = myVariable3 +5;
  
  println("var1: " + myVariable1 + " /var2: " + myVariable2 + " var3: " + myVariable3);
  
  int sum;
  sum = myVariable1 + myVariable2 + myVariable3;
  println("the sum is: " + sum);
}
