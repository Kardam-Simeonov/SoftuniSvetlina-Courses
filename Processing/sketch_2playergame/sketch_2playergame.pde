float total = 100;
int player1 = 0;
int player2 = 0;

boolean swap = false;

void setup() {
  size(1000,1000);
}
void draw() {
}
void mousePressed() {
  int randomNumber = int(random(1,20));
  //PLAYER1 METHOD
  if (swap == false && player2 < 100 && player1 < 100) {
     player1 += randomNumber;
     println("Player1: " + player1 );
       swap = !swap;
     /////////////////////////   
  if (player1 >= total) {
      println("PLAYER1 IS WINNER WITH  " + player1 + " points" );
      background(0,255,0);
    }
  //PLAYER2METHOD
} else if (swap = true && player1 < 100 && player2 < 100) {
     player2 += randomNumber;
     println("Player2: " + player2 );
     swap = !swap;
     ////////////////////////
     if (player2 >= total) {
      println("PLAYER2 IS WINNER WITH  " + player2 + " points" );
      background(0,255,0);
    }
   
    
  } 

}
