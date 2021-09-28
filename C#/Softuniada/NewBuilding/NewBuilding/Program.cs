using System;

namespace NewBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int height = length + length / 2;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    bool IsSeat = (j + i) % 4 == 0;

                    if (IsSeat)
                        Console.Write("#");

                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }
    }
}
