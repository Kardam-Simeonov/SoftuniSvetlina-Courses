String name = "Bob";
int number = 10;
void setup() {
  size(200,200);
  hello(name, number);
  
  goodbye(name, number);
 
}

void draw() {

}

void hello(String name, int number) {
  print("Hello,"  ,name, number);
  printPeriod();
}

void goodbye(String name, int number){
  print("Goodbye," ,name, number);
  printPeriod();
}

void printPeriod(){
  println(".");
}
