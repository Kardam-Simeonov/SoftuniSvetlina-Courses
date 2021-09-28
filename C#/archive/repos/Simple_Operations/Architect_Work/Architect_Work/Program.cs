using System;

namespace Architect_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int work_time = 3;

            int result = work_time * projects;

            Console.WriteLine($"The architect {name} will need {result} hours to complete {projects} project/s.");


        }
    }
}
