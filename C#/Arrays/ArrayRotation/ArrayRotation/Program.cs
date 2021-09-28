using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            for (int j = 1; j <= rotations; j++)
            {
                int copyOfFirst = array[0];

                for (var i = 0; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }

                array[array.Length - 1] = copyOfFirst;
            }

            Console.WriteLine(String.Join(" ", array));
        }
    }
}
