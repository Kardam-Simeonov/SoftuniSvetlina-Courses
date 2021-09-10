using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterBonuses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalBonusSum = 0;

            while (input != "stop")
            {
                string name = input;
                int[] completedTasks = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                int employeeBonus = 0;

                for (int i = 0; i < completedTasks.Length; i++)
                {
                    int multiplication = -1;
                    for (int j = 0; j < completedTasks.Length; j++)
                    {
                        if (j != i)
                        {
                            if (multiplication == -1)
                                multiplication = completedTasks[j];
                            else
                                multiplication *= completedTasks[j];
                        }
                    }
                    employeeBonus += multiplication;
                }

                totalBonusSum += employeeBonus;
                Console.WriteLine($"{name} has a bonus of {employeeBonus} lv.");
                input = Console.ReadLine();
            }

            Console.WriteLine($"The amount of all bonuses is {totalBonusSum} lv.");
        }
    }
}
