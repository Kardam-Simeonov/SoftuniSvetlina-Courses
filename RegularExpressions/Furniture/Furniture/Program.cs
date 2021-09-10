using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string expression = @">>(?<furniture>.+)<<(?<price>\d+|\d+\.\d+)!(?<quantity>\d)";
            double totalPrice = 0;
            List<Match> boughtFurniture = new List<Match>();

            while (input != "Purchase")
            {
                if (Regex.IsMatch(input, expression))
                {
                    Match validExpression = Regex.Match(input, expression);
                    boughtFurniture.Add(validExpression);
                    totalPrice += Convert.ToDouble(validExpression.Groups["price"].Value) * Convert.ToDouble(validExpression.Groups["quantity"].Value);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            boughtFurniture.ForEach(x => Console.WriteLine(x.Groups["furniture"].Value));
            Console.WriteLine($"Total money spend: {totalPrice}");
        }
    }
}
