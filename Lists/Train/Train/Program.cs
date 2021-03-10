using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> peopleInWagons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ");
                if (command[0] == "end")
                {
                    break;
                }
                else if (command[0] == "Add")
                { 
                    peopleInWagons.Add(Int32.Parse(command[1]));
                }
                else if (command.Length == 1)
                {
                    for (int i = 0; i < peopleInWagons.Count; i++)
                    {
                        if (CanPeopleFit(peopleInWagons[i], int.Parse(command[0]), maxCapacity) )
                        {
                            peopleInWagons[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }
            }
                
            Console.WriteLine(String.Join(" ", peopleInWagons));;
        }

        static bool CanPeopleFit(int wagon, int addedPeople, int maxCapacity)
        {
            if (wagon + addedPeople <= maxCapacity)
                return true;
            
            return false;
        }
    }
}
