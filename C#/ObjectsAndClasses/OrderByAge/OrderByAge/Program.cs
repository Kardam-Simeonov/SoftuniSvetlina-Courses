using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End")
                    break;

                Person userPerson = new Person(input[0], input[1], int.Parse(input[2]));
                peopleList.Add(userPerson);
            }

            foreach (var person in peopleList.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
