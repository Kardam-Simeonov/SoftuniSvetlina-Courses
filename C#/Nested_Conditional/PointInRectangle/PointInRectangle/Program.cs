using System;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());


            if (y == y1)
            {
                if (x > x1 && x < x2)
                    Console.WriteLine("Border");
                else if (x == x1 || x == x2)
                    Console.WriteLine("Border");
                else
                    Console.WriteLine("Inside / Outside");

            }
            else if (y == y2)                             //
            {
                if (x > x1 && x < x2)
                    Console.WriteLine("Border");
                else if (x == x1 || x == x2)
                    Console.WriteLine("Border");
                else
                    Console.WriteLine("Inside / Outside");
            }

            else if (x == x1)
            {
                if (y > y1 && y < y2)
                    Console.WriteLine("Border");
                else if (y == y1 || x == y2)
                    Console.WriteLine("Border");
                else
                    Console.WriteLine("Inside / Outside");
            }
            else if (x == x2)
            {
                if (y > y1 && y < y2)
                    Console.WriteLine("Border");
                else if (y == y1 || x == y2)
                    Console.WriteLine("Border");
                else
                    Console.WriteLine("Inside / Outside");
            }

            else
                Console.WriteLine("Inside / Outside");

             

        }
    }
}
