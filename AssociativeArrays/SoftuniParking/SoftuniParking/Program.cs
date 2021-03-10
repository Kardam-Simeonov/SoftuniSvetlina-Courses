using System;
using System.Collections.Generic;

namespace SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parkingList = new Dictionary<string, string>();

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "register")
                {
                    if (parkingList.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
                    }
                    else
                    {
                        parkingList.Add(input[1], input[2]);
                        Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                    }
                }

                else if (input[0] == "unregister")
                {
                    if (!parkingList.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                    else
                    {
                        parkingList.Remove(input[1]);
                        Console.WriteLine($"{input[1]} unregistered successfully");
                    }
                }
            }

            foreach (var item in parkingList)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
