using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenghth = double.Parse(Console.ReadLine());

            double volume = width * lenghth;

            while (true)
            {
                string slices = Console.ReadLine();


                if (slices == "STOP")
                {
                    Console.WriteLine($"{volume} pieces are left.");
                    break;
                }
                else 
                {
                    if (volume - double.Parse(slices) <= 0)
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(volume - double.Parse(slices))} pieces more.");
                        break; 
                    }
                    else
                       volume -= double.Parse(slices);
                }
            }

        }
    }
}
