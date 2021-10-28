using System;

namespace WeeklyPay
{
    class Program
    {
        static void Main(string[] args)
        {
            double workplaceTwoDailyPay = double.Parse(Console.ReadLine());
            int workplaceOneDays = int.Parse(Console.ReadLine());

            double workplaceTwoPay = workplaceTwoDailyPay * 3;
            double workplaceOnePay = workplaceOneDays * 60;

            if (workplaceOneDays > 7 || workplaceOneDays < 0)
            {
                Console.WriteLine($"{workplaceOneDays} is invalid number.");
                System.Environment.Exit(0);
            }
                
            for (int i = 1; i <= workplaceOneDays; i++)
            {
                string dayName = Console.ReadLine();

                if (dayName == "Friday" || dayName == "Saturday")
                    workplaceOnePay += 9;
            }

            Console.WriteLine($"{(workplaceOnePay + workplaceTwoPay):f2}");
        }
    }
}
