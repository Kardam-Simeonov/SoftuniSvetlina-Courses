using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family members = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                members.AddMember(new Person(input[0], int.Parse(input[1])));
            };

            Console.WriteLine(members.GetOldestMember());
        }
    }
}
