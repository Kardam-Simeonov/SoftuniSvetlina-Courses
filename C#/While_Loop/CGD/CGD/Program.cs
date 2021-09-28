using System;

namespace CGD
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = 0;

            if (b == 0)
            {
                result = a;
            }
            else
            {
                while (b != 0)
                {
                    result = b;
                    b = a % b;
                    a = result;
                }
            }

            Console.WriteLine(result);
        }
    }
}
