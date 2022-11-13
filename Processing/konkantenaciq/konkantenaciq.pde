size(500,500);
String message1 = "message 1";
String message2 = "message 3";
//КОНКАТЕНАЦИЯ
String message3 = message1 + " " + message2;
String message4 = message1 + " " + "four";

int num1 = 1;
float num2 = 2.0;

println(message3 + num1);
println(message3, num1);

message3 = "new value for message 3";
println(message3, num1);
println(message3, num2);

message3 = message3 + message4;

background(255);
fill(0);
textSize(20);
text(message3, 10, 30);
text(num1,30,60);
