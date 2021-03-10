
using System;

namespace BeeRole
{
    class Program
    {
        static void Main(string[] args)
        {
            // the user fills the three variables for intellect,
            //strenght and gender
            int intellect = int.Parse(Console.ReadLine());
            int strength = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            //the role of the bee is stored here, its empty for now
            string role = "";

            if (intellect >= 80)      //first we check if the intellect is greater than or equal to 80
            {
                if (strength >= 80)     //then we check if the strength is greater than or equal to 80
                {
                    // Finally if the gender is female,
                    // the role is assigned to Queen Bee
                    if (gender == "female")
                        role = "Queen Bee";
                }
                else                       // if the strength is lesser than 80
                    role = "Repairing Bee";  // then the role is assigned to Repairing Bee
            }

            else if (intellect >= 60)       // if the intellect is lesser than 80, but greater than or equal to 60
            {
                //then the role is assigned to Cleaning Bee
                role = "Cleaning Bee";
            }

            else          //if the intellect doesn't meet the criteria above
            {
                if (strength >= 80)         // we check if the strength is greater than or equal to 80
                {
                    //finally if the gender is male,
                    // the role is assigned to Drone Bee
                    if (gender == "male")
                        role = "Drone Bee";
                }
                else if (strength >= 60)  // if else he strength is lesser than 80, but greater than or equal to 60
                    role = "Guard Bee";    // the role is assigned to Guard Bee

                else if (gender == "male" || gender == "female")                    //lastly if the strength doesn't meet the criteria above,
                    role = "Worker Bee";     // the role is assigned to Worker Bee
            }

            //Finally we print the role of the bee
            Console.WriteLine(role);
        }
    }
}
