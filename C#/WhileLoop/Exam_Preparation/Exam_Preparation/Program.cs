using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            double poorGrades = double.Parse(Console.ReadLine());

            double numberProblems = 0;
            double numberPoorGrades = 0;

            double gradesSum = 0;
            string lastProblem = "";

            while (true)
            {
                string question = Console.ReadLine();
                if (question == "Enough")
                {
                    Console.WriteLine($"Average score: {gradesSum / numberProblems:f2}");
                    Console.WriteLine($"Number of problems: {numberProblems}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                double grade = double.Parse(Console.ReadLine());
                numberProblems++;
                gradesSum += grade;
                lastProblem = question;

                if (grade <= 4)
                {
                    numberPoorGrades++;
                    if (numberPoorGrades == poorGrades)
                    {
                        Console.WriteLine($"You need a break, {poorGrades} poor grades.");
                        break;
                    }
                }      
            }
        }
    }
}
