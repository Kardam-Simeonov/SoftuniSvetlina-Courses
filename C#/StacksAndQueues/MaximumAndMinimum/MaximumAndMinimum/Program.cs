using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> canOfPringles = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (input[0])
                {
                    case 1:
                        canOfPringles.Push(input[1]);
                        break;
                    case 2:
                        if (canOfPringles.Count > 0)
                            canOfPringles.Pop();
                        break;
                    case 3:
                        if (canOfPringles.Count > 0)
                            Console.WriteLine(canOfPringles.Max()); 
                        break;
                    case 4:
                        if (canOfPringles.Count > 0)
                            Console.WriteLine(canOfPringles.Min());
                        break;
                    default:
                        break;
                }
            }

            if (canOfPringles.Count > 0)
                Console.WriteLine(String.Join(", ", canOfPringles));
        }
    }
}
