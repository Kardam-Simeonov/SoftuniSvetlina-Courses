using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            PrintDivisonOfFactorial(numOne, numTwo);
        }

        static void PrintDivisonOfFactorial(double numOne, double numTwo)
        {
            double factorialOne = numOne;
            double factorialTwo = numTwo;

            for (double i = numOne - 1; i >= 1; i--)
            {
                factorialOne *= i;
            }
            for (double i = numTwo - 1; i >= 1; i--)
            {
                factorialTwo *= i;
            }

            Console.WriteLine($"{(factorialOne / factorialTwo):F2}");
        }
    }
}
