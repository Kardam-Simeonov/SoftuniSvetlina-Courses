using System;

namespace Difference
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            DateDifferenceCalculator calculator = new DateDifferenceCalculator(firstInput, secondInput);

            calculator.CalculateDifference();
        }
    }
}
