using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> companies = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("->");

                if (input[0] == "End")
                    break;

                if (companies.ContainsKey(input[0]))
                    companies[input[0]].Add(input[1]);
                else
                    companies.Add(input[0], new HashSet<string> { input[1] });
            }

            foreach (var company in companies.OrderBy(key => key.Key))
            {
                Console.WriteLine($"{company.Key.TrimEnd()}");
                foreach (var item in company.Value)
                {
                    Console.WriteLine($"--{item}");
                }
            }
        }
    }
}
