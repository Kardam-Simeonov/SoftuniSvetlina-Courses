using System;

namespace BigBrotherSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            double times = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            
            for (int i = 0; i < times; i++)
            {
                string tab = Console.ReadLine().ToLower();

                    switch (tab)
                    {
                        case "facebook":
                            salary -= 150;
                            break;
                        case "instagram":
                            salary -= 100;
                            break;
                        case "reddit":
                            salary -= 50;
                            break;
                        default:
                            break;
                    }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    System.Environment.Exit(0);
                }
            }

            Console.WriteLine(salary);
        }
    }
}
