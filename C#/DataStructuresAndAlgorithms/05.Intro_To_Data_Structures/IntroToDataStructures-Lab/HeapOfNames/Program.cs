using MoreComplexDataStructures;
using System;

namespace HeapOfNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxHeap<string> heap = new MaxHeap<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                heap.Insert(Console.ReadLine());
            }

            while (heap.Count > 0)
            {
                Console.WriteLine(heap.ExtractMax());
            }
        }
    }
}
