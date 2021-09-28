using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballNum = int.Parse(Console.ReadLine());
            double highestValue = double.MinValue;
            string output = "";
            for (int i = 1; i <= snowballNum; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                double snowballValue = Math.Pow((snowballSnow / snowballTime), snowballQuality);


                if (highestValue < snowballValue)
                {
                    output = $"{snowballSnow} : {snowballTime} = {highestValue} ({snowballQuality})";
                }
           
            }

            Console.WriteLine(output);
        }
    }
}
