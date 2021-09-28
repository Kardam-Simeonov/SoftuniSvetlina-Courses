using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            bool isDone = false;

            while (isDone != true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                switch (command[0])
                {
                    case ("Delete"):
                        numbers.Remove(int.Parse(command[1]));
                        break;

                    case ("Insert"):
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;

                    case ("end"):
                        isDone = true;
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
