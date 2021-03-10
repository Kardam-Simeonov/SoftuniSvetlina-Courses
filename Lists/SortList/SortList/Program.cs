using System;
using System.Collections.Generic;

namespace SortList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == -1)
                    break;

                numbers.Add(num);
            }

            numbers.Sort();
            numbers.ForEach(Console.WriteLine);
            //Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
