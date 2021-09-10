using System;
using System.Linq;

namespace SoftJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];

            string[] playBoard = new string[n];

            for (int i = 0; i < n; i++)
            {
                playBoard[i] = Console.ReadLine();
            }

            int jumps = int.Parse(Console.ReadLine());

            for (int i = 0; i < jumps; i++)
            {
                int[] coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();


            }
        }
    }
}
