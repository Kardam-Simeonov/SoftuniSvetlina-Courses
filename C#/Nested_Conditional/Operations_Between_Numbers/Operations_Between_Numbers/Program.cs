using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());

            if (op == '+')
            {
                if ((n1+n2)% 2 == 0)
                    Console.WriteLine($"{n1} + {n2} = {n1+n2} - even");
                else
                    Console.WriteLine($"{n1} + {n2} = {n1 + n2} - odd");

            }
            else if (op == '-')
            {
                if ((n1 - n2) % 2 == 0)
                    Console.WriteLine($"{n1} - {n2} = {n1 - n2} - even");
                else
                    Console.WriteLine($"{n1} - {n2} = {n1 - n2} - odd");

            }
            else if (op == '*')
            {
                if ((n1 * n2) % 2 == 0)
                    Console.WriteLine($"{n1} * {n2} = {n1 * n2} - even");
                else
                    Console.WriteLine($"{n1} * {n2} = {n1 * n2} - odd");

            }
            else if (op == '/')
            {
                if (n2 == 0)
                    Console.WriteLine($"Cannot divide {n1} by zero");
                else
                    Console.WriteLine($"{n1} / {n2} = {(n1 / n2):f2}");

            }
            else if (op == '%')
            {
                if (n2 == 0)
                    Console.WriteLine($"Cannot divide {n1} by zero");
                else
                    Console.WriteLine($"{n1} % {n2} = {n1 % n2}");

            }
        }
    }
}
