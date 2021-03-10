using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double avg = double.Parse(Console.ReadLine());

            double social = avg * 0.35;
            double excellent = grade * 25;

            if (grade >= 5.5 && excellent >= social)
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellent)} BGN");

            else if (income < avg && grade > 4.50 && social > excellent)
                Console.WriteLine($"You get a Social scholarship {Math.Floor(social)} BGN");
           
            else
                Console.WriteLine("You cannot get a scholarship!");
        }
    }
}