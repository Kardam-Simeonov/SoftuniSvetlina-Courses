using System;

namespace HoneyWinterReserves
{
    class Program
    {
        static void Main(string[] args)
        {
            // The required amount of honey, filled by the user
            // And a variable, responsible for keeping track of the total collected honey
            double honeyRequired = double.Parse(Console.ReadLine());
            double honeyAmount = 0;

            // We use a while loop, that will run until broken out of 
            while (true)                
            {
                string input = Console.ReadLine();        // We get the user's input (bee name or "Winter has come")
                double honeyCollected = 0;     // We will use this variable to keep track of collected honey per bee

                if (input == "Winter has come")      // We check if the user has submited the command for ending the loop
                    break;   // In that case we break out of it

                // Using a for loop to cycle through the collected honey
                // for each month
                for (int i = 1; i <= 6; i++)       
                    honeyCollected += double.Parse(Console.ReadLine());
                
                // Checking if a bee has eaten more
                // honey than collected and printing out the adequate message
                if (honeyCollected < 0)
                    Console.WriteLine($"{input} was banished for gluttony");

                honeyAmount += honeyCollected;  // adding the bee's honey to the total

                // Checking if we have collected the required honey
                // if it's true, then we print out the message and break out of the loop
                if (honeyAmount >= honeyRequired)
                {
                    Console.WriteLine($"Well done! Honey surplus {(honeyAmount - honeyRequired):f2}.");
                    break;
                }
            }
            // We check if we have the required honey, after we have broken out of the loop
            // and printing out the adequate message
            if (honeyAmount < honeyRequired)
                Console.WriteLine($"Hard Winter! Honey needed {(honeyRequired - honeyAmount):f2}.");
        }
    }
}
