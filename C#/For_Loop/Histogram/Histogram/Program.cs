using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double times = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < times; i++)
            {
                double num = double.Parse(Console.ReadLine());

                switch (num)
                {
                    case double n when (num < 200):          //the var n takes the value of num
                        p1++;
                        break;
                    case double n when (num >= 200 && num < 400):
                        p2++;
                        break;
                    case double n when (num >= 400 && num < 600):
                        p3++;
                        break;
                    case double n when (num >= 600 && num < 800):
                        p4++;
                        break;
                    case double n when (num >= 800):
                        p5++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"{((p1 / times) * 100):f2}%");
            Console.WriteLine($"{((p2 / times) * 100):f2}%");
            Console.WriteLine($"{((p3 / times) * 100):f2}%");
            Console.WriteLine($"{((p4 / times) * 100):f2}%");
            Console.WriteLine($"{((p5 / times) * 100):f2}%");
           




        }
    }
}
