using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = people / capacity + (people % capacity != 0 ? 1 : 0);

            Console.WriteLine(courses);
        }
    }
}
