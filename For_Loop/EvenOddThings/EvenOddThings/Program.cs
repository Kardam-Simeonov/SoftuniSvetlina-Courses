using System;

namespace EvenOddThings
{
    class Program
    {
        static void Main(string[] args)
        {
            double times = double.Parse(Console.ReadLine());
            double evenMaxNum = double.MinValue;
            double evenMinNum = double.MaxValue;
            double oddMaxNum = double.MinValue;
            double oddMinNum = double.MaxValue;
            double evenSum = 0;
            double oddSum = 0;

            for (int i = 1; i <= times; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;

                    if (num > evenMaxNum)
                        evenMaxNum = num;
                    if (num < evenMinNum)
                        evenMinNum = num;
                }
                else if (i % 2 == 1)                  // chisloto se roundva obache kogato e ,5 go kachva, TRQBVA DA GO SVALQ
                {
                    oddSum += num;

                    if (num > oddMaxNum)
                        oddMaxNum = num;
                    if (num < oddMinNum)
                        oddMinNum = num;
                }
                   
            }

            Console.WriteLine($"OddSum={oddSum:f2}");
            Console.Write("OddMin=");
            if (oddMinNum < double.MaxValue)
                Console.WriteLine($"{oddMinNum:f2}");
            else
                Console.WriteLine($"No");

            
            Console.Write("OddMax=");
            if (oddMaxNum > double.MinValue)
                Console.WriteLine($"{oddMaxNum:f2}");
            else
                Console.WriteLine($"No");


            Console.WriteLine($"EvenSum={evenSum:f2}");
            Console.Write("EvenMin=");
            if (evenMinNum < double.MaxValue)
                Console.WriteLine($"{evenMinNum:f2}");
            else
                Console.WriteLine($"No");


            Console.Write("EvenMax=");
            if (evenMaxNum > double.MinValue)
                Console.WriteLine($"{evenMaxNum:f2}");
            else
                Console.WriteLine($"No");


           

        }
    }
}
