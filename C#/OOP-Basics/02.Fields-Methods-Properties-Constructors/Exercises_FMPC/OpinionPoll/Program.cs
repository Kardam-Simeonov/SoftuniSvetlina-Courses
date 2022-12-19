using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> peopleAbove30 = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (int.Parse(input[1]) > 30)
                    peopleAbove30.Add(new Person(input[0], int.Parse(input[1])));
            }

            foreach (var person in peopleAbove30.OrderBy(x => x.Name))
            {
                Console.WriteLine(person);
            }
        }
    }
}
