using System;
using System.Linq;

namespace ProgramLoyalCustomer
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Customer inputCustomer = new Customer(int.Parse(input[0]), input[1], int.Parse(input[2]), input[3]);
            
            while (input[0] != "End")
            {
                if (input[0] == "Bonus" && input[1] == "Points")
                    inputCustomer.AddBonusPoints(int.Parse(input[2]));

                else if (input[0] == "Exchange")
                    inputCustomer.ExchangePoints(int.Parse(input[1]));

                input = Console.ReadLine().Split();
            }
        }
    }
}
