using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "END")
            {
                people.Add(new Person(input[0], int.Parse(input[1]), input[2]));
                input = Console.ReadLine().Split(' ');
            }

            int n = int.Parse(Console.ReadLine());

            Person nthPerson = people[n - 1];

            int equalPeople = people.Where(x => nthPerson == x).ToList().Count() - 1;
            int unequalPeople = people.Where(x => nthPerson == x).ToList().Count();

            if (equalPeople > 0)
                Console.WriteLine($"{equalPeople} {unequalPeople} {people.Count}");
            else
                Console.WriteLine("No matches");
        }
    }
}
