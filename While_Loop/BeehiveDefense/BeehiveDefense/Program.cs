using System;

namespace BeehiveDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            // The user fills the three variables for number of bees, bear health and bear attack
            double bees = double.Parse(Console.ReadLine());
            double bearHealth = double.Parse(Console.ReadLine());
            double bearAttack = double.Parse(Console.ReadLine());

            //these two bool variables determine who's on
            bool bearTurn = true;
            bool beesTurn = false;

            while (true)              //a while loop that will run until broken out of
            {
                if (bees < 100)            // if the bees are less than 100
                {
                    if (bees < 0)         // if the bees are less than 0, we print out number of bees as 0 and break
                    {
                        Console.WriteLine($"The bear stole the honey! Bees left 0."); 
                        break;
                    }
                    else        // else we print out the actual number of bees and break
                    {
                        Console.WriteLine($"The bear stole the honey! Bees left {bees}.");
                        break;
                    }
                }
                else if (bearHealth <= 0)        //if the bear's health falls under or is equal to 0
                {
                    Console.WriteLine($"Beehive won! Bees left {bees}.");  //the beehive wins and we print out the number of bees
                    break;
                }

                if (bearTurn == true)         // if it's the bear's turn
                {
                    bees -= bearAttack;    // the bear attacks and the number of bees is lowered
                    bearTurn = false;     // we change the bool vars so it's now the bees turn
                    beesTurn = true;
                }
                else if (beesTurn == true)  // if it's the bees turn
                {
                    bearHealth -= bees * 5;   // the bees attack and the health of the bear is lowered
                    beesTurn = false;   // we change the bool vars so it's now the bear's turn
                    bearTurn = true;
                }

            }
        }
    }
}
