using System;

namespace DividieWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double times = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < times; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (num % 2 == 0)          
                    p1++;
                if (num % 3 == 0)
                    p2++;
                if (num % 4 == 0)
                    p3++;  
            }

            Console.WriteLine($"{((p1 / times) * 100):f2}%");
            Console.WriteLine($"{((p2 / times) * 100):f2}%");
            Console.WriteLine($"{((p3 / times) * 100):f2}%");
            
        }
    }

}
 

