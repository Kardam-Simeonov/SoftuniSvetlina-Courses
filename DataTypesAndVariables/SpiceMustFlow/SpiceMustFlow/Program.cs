using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int spiceExtracted = 0;

            while (startingYield >= 100)
            {
                spiceExtracted += startingYield - 26;
                days++;
                startingYield -= 10;
            }

            if (spiceExtracted > 26)
                spiceExtracted -= 26;
                
            Console.WriteLine(days);
            Console.WriteLine(spiceExtracted);
        }
    }
}
