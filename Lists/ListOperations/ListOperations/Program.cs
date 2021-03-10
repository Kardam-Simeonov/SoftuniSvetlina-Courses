using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' '); 
                if (input[0] == "end")
                    break;


                switch (input[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(input[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(input[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(input[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                        break;
                }
            }
        }
    }
}
