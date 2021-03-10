using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalGradeSum = 0;
            double presentations = 0;
            int juryNumber = int.Parse(Console.ReadLine());

            while (true)
            {
                double gradeSum = 0;
                string input = Console.ReadLine();
                if (input == "Finish")
                    break;
                
                for (int i = 1; i <= juryNumber; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeSum += grade;
                }

                Console.WriteLine($"{input} - {(gradeSum / juryNumber):f2}.");
                presentations+= juryNumber;
                totalGradeSum += gradeSum;
            }

            Console.WriteLine($"Student's final assessment is {(totalGradeSum / presentations):f2}.");
        }
    }
}
