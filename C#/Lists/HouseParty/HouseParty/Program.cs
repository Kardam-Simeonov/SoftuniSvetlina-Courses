using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] name = Console.ReadLine().Split(" ").ToArray();

                if (name[2] == "going!")
                {
                    if (nameList.Any(x => name[0] == x))
                    {
                        Console.WriteLine($"{name[0]} is already in the list!");
                        continue;
                    }

                    nameList.Add(name[0]);
                }
                else if (name[2] == "not")
                {
                    if(nameList.Any(x => name[0] == x))
                    {
                        nameList.Remove(name[0]);
                        continue;
                    }

                    Console.WriteLine($"{name[0]} is not in the list!");
                }
            }

            nameList.ForEach(Console.WriteLine);
        }
    }
}
