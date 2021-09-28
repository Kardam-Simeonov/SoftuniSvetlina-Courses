using System;
using System.Transactions;

namespace Art_ClubEXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] actionPeople = new double[] { 0, 0, 0, 0 };       //an array for the people doing somethig is initialized, the array positions are: paint, knit, sing and dance
            double[] buyingPeople = new double[] { 0, 0 };             //an array for the people buying things is initialized, the array positions are: souvenir and tea

            double people = double.Parse(Console.ReadLine());            //The number of people that the user sets

            for (int i = 1; i <= people; i++)                           // a for loop which loops for every person that the user set
            {
                string action = Console.ReadLine();                        //the action of the person - Paint, Knit, Sing, Dance, Souvenir, Tea
                switch (action)                                            // a switch case that goes through all the possible actions that the person can do
                {
                    case "Paint":                                         //if the person's action is equal to a certain action, then the corresponding value in its array goes up with 1
                        actionPeople[0]++;                                // then it breaks out of the case
                        break;                                            // this is the same for each case                            
                    case "Knit":
                        actionPeople[1]++;
                        break;
                    case "Sing":
                        actionPeople[2]++;
                        break;
                    case "Dance":
                        actionPeople[3]++;
                        break;
                    case "Souvenir":
                        buyingPeople[0]++;
                        break;
                    case "Tea":
                        buyingPeople[1]++;
                        break;
                    default:                                   //the default case just breaks out of the switch case
                        break;
                }
            }
            double actionTotal = actionPeople[0] + actionPeople[1] + actionPeople[2] + actionPeople[3];   //this double variable holds the sum of the "people doing something" array
            double buyingTotal = buyingPeople[0] + buyingPeople[1];                                       //this double variable holds the sum of the "people buying things" array

            double totalPeople = actionTotal + buyingTotal;                                             // this double variable holds the sum of the total people                    
            double creatingArt = (actionTotal / totalPeople) * 100;                                  //this variable calculates the percent of people creating art
            double buyingProduct = (buyingTotal / totalPeople) * 100;                               //this variable calculates the percent of people buying a product

            Console.WriteLine($"{actionPeople[0]} - Paint");                                 //this prints out the amount of people painting
            Console.WriteLine($"{actionPeople[1]} - Knit");                                  //this prints out the amount of people knitting
            Console.WriteLine($"{actionPeople[2]} - Sing");                                 //this prints out the amount of people singing
            Console.WriteLine($"{actionPeople[3]} - Dance");                                //this prints out the amount of people dancing
            Console.WriteLine($"{buyingPeople[0]} - Souvenir");                             //this prints out the amount of people buying a souvenir
            Console.WriteLine($"{buyingPeople[1]} - Tea");                                 //this prints out the amount of people buying tea
            Console.WriteLine($"{creatingArt:f2}% - creating art");                //this prints out the percent of people creating art and formats the double var to the second number after the comma
            Console.WriteLine($"{buyingProduct:f2}% - buying a product");         //this prints out the percent of people buying a product and formats the double var to the second number after the comma


        }
    }
}
