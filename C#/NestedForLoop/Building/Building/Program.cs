using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int roomsPerFloor = int.Parse(Console.ReadLine());


            for (int i = floors; i >= 1; i--)
            {
                for (int n = 0; n < roomsPerFloor; n++)
                {
                    if (i == floors)
                    {
                        Console.Write($"L{i}{n} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{n} ");
                    }
                    else
                        Console.Write($"A{i}{n} ");
                }
                Console.WriteLine("");
            }



        }
    }
}
