
using System;

namespace BeehiveRole
{
    class Program
    {
        static void Main(string[] args)
        {
            // the user fills the three variables for intellect,
            //strength and gender
            int intellect = int.Parse(Console.ReadLine());
            int strength = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            //the role of the bee is stored here, its empty for now
            string role = "";  

            if (intellect >= 80 && strength >= 80 && gender == "female")                     //first we check if the bee is a queen
                role = "Queen Bee"; // if the criteria are met, then the role is assigned to Queen Bee
            
            else if (intellect >= 80 )     // If the bee is not a queen, we check if the bee fits the role for a repair bee
                role = "Repairing Bee";  // if the criteria are met, then the role is assigned to Repairing Bee
          
            else if (intellect >= 60)  // If the bee is not a queen or a repair bee, we check if it's a cleaning bee
                role = "Cleaning Bee";     // if the criteria are met, then the role is assigned to Cleaning Bee
        
            else   // If the bee doesn't meet any of the criteria for intellect or for queen
            {
                if (strength >= 80 && gender == "male")               // we check if the bee meets the criteria for Drone Bee
                    role = "Drone Bee"; // If the criteria are met, then the role is assigned to Drone Bee
            
                else if (strength >= 60)     // if else the bee is not a Drone Bee, we check if it's a guard bee
                    role = "Guard Bee";   // if the criteria are met, then the role is assigned to Guard Bee

                else                        //lastly if we don't meet any requirements above 
                    role = "Worker Bee";       // the role is assigned to Worker Bee
            }

            //Finally we print the role of the bee
            Console.WriteLine(role);     
        }
    }
}
