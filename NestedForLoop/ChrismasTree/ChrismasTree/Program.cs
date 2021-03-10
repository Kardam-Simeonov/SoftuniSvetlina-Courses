using System;

namespace ChrismasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()) + 1;

            for (int row = 1; row <= num; row++)
            {
                for (int col = 0; col < num - row; col++)
                    Console.Write(' ');
                
                for (int col = 2; col <= row; col++)
                    Console.Write("*");

                Console.Write(" | ");
                

                for (int col = 2; col <= row; col++)
                    Console.Write("*");


                Console.WriteLine();
            }
        }
    }
}
