using System;
using Wintellect.PowerCollections;

namespace BagOfWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderedBag<string> bag = new OrderedBag<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                bag.Add(Console.ReadLine());
            
            bag.ForEach(x => Console.WriteLine(x));
        }
    }
}
