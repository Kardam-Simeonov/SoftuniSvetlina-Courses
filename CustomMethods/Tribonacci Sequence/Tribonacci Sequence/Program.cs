using System;

namespace Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintSequence(num);
        }

        static void PrintSequence(int num)
        {
            int x = 1;
            int y = 1;
            int e = 2;
            int z;
            Console.Write($"{x} {y} {e} ");
            

            for (int i = 3; i < num; i++)
            {
                z = e + x + y;
                Console.Write(z + " ");
                x = y;
                y = e;
                e = z;
            }

        }
    }
}
