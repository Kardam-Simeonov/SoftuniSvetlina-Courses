using System;

namespace EventCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int firstNumber = int.Parse(numbers[0]);
            int secondNumber = int.Parse(numbers[1]);
            
            AddTwoNumbers calculator = new AddTwoNumbers();
            calculator.OddNumberEvent += (sender, e) =>
            {
                Console.WriteLine("********Event Executed : This is Odd Number**********");
            };
            calculator.Add(firstNumber, secondNumber);
        }
    }
}
