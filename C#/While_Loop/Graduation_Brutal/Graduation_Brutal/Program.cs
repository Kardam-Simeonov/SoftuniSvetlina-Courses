using System;

namespace Graduation_Brutal
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double grades = 0;
            double sum = 0;

            int failures = 0;
            bool isfailed = false;

            while (grades <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    sum += grade;
                    grades += 1;
                }
                else
                {
                    sum += grade;
                    grades += 1;
                    failures += 1;
                }

                if (failures > 1)
                {
                    isfailed = true;
                    break;
                }
            }

            double average = sum / 12;
            if (isfailed == false)
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            else
                Console.WriteLine($"{name} has been excluded at {grades - 1} grade");


        }
    }
}
