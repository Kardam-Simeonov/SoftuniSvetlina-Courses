using System;
using System.Text.RegularExpressions;

namespace GameBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex expression = new Regex(@"%([A-Z][a-z]+)%<([A-Za-z]+)>\|([0-9]+)\|([0-9]+[.][0-9]|[0-9]+)\$");
            double totalPrice = 0.0;

            while (input != "end of shift")
            {
                if (expression.IsMatch(input))
                {
                    Match match = expression.Match(input);

                    string name = match.Groups[1].Value;
                    string productName = match.Groups[2].Value;
                    int quantity = int.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);

                    Console.WriteLine($"{name}: {productName} - {quantity * price:f2}");
                    totalPrice += quantity * price;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
