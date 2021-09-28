using System;

namespace Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMinutes = double.Parse(Console.ReadLine());
            double neededseconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsforHundred = double.Parse(Console.ReadLine());

            double neededTime = neededMinutes * 60 + neededseconds;
            double reducedTime = (distance / 120) * 2.5;

            double marinTime = ((distance / 100) * secondsforHundred) - reducedTime;

            if (marinTime <= neededTime)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {marinTime:f3}.");
            }
            else if (marinTime > neededTime)
                Console.WriteLine($"No, Marin failed! He was {(marinTime - neededTime):f3} second slower.");
        }
            
    }
}
