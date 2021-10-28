using System;
using System.Linq;
using Fractions;

namespace CalculationWithFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int[] firstInputFraction = input[0].Split("/").Select(int.Parse).ToArray();
            int[] secondInputFraction = input[2].Split("/").Select(int.Parse).ToArray();

            char action = char.Parse(input[1]);

            Fraction firstFraction = new Fraction(firstInputFraction[0], firstInputFraction[1]);
            Fraction secondFraction = new Fraction(secondInputFraction[0], secondInputFraction[1]);
            Fraction resultFraction = new Fraction();

            switch (action)
            {
                case '+':
                    resultFraction = firstFraction + secondFraction;
                    break;
                case '-':
                    resultFraction = firstFraction - secondFraction;
                    break;
            }

            Console.WriteLine($"{firstFraction} {action} {secondFraction} = {resultFraction}");
        }
    }
}
