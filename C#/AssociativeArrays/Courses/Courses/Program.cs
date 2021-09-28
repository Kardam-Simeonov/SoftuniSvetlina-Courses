using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(':');

                if (input[0] == "end")
                    break;

                if (courses.ContainsKey(input[0]))
                    courses[input[0]].Add(input[1]);
                else
                    courses.Add(input[0], new List<string> { input[1] });
            }

            foreach (var course in courses.OrderByDescending(key => key.Value.Count))
            {
                Console.WriteLine($"{course.Key.TrimEnd()}: {course.Value.Count}");
                course.Value.Sort();
                course.Value.ForEach(x => Console.WriteLine($"--{x}"));
            }
        }
    }
}
