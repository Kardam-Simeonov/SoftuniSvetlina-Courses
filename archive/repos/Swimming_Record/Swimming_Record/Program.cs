using System;

namespace Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine());
            double recordDistance = double.Parse(Console.ReadLine());
            double timePerM = double.Parse(Console.ReadLine());

            double neededTime = recordDistance * timePerM;
            double addedTime = Math.Floor((recordDistance / 15)) * 12.5;
          


            double totalTime = neededTime + addedTime;

            if (totalTime < recordTime)
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            else
                Console.WriteLine($"No, he failed! He was {(Math.Abs((recordTime - totalTime))):f2} seconds slower.");

           
        }
    }
}
