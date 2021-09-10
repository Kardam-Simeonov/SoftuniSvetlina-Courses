using System;
using System.Collections.Generic;
using System.Linq;

namespace HolidayTreat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] staffList = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int boxes = int.Parse(Console.ReadLine());

            int totalTreats = 0;
            staffList.Select(x => totalTreats += x);

            int treatsPerBox = totalTreats / boxes;

            //List<List<int>> packages = new List<List<int>>();

            for (int i = 0; i < staffList.Length; i++)
            {
                int totalSum = staffList[i];
                for (int j = 0; j < staffList.Length; j++)
                {
                    if (i != j)
                    {
                        Console.WriteLine("i != j");
                        if (totalSum + staffList[j] == treatsPerBox)
                        {
                            Console.WriteLine("true");
                            Environment.Exit(0);
                        }
                        else if (totalSum + staffList[j] < treatsPerBox)
                        {
                            totalSum += staffList[j];
                            Console.WriteLine("second if");
                        }
                            
                    }
                }
                Console.WriteLine(i);
            }
        }
    }
}
