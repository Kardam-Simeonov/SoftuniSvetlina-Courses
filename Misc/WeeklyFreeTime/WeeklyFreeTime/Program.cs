using System;
using System.Runtime;

namespace WeeklyFreeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string vibeCheckDay = Console.ReadLine();
            int vibeCheckHour = int.Parse(Console.ReadLine());
            bool isFree = true;

            if (vibeCheckHour < 10 || vibeCheckHour > 22)
            {
                Console.WriteLine($"You cannot disturb Maria on {vibeCheckDay} at {vibeCheckHour}.");
                System.Environment.Exit(0);
            }

            int workplaceOneDays = int.Parse(Console.ReadLine());

            if (workplaceOneDays < 3 || workplaceOneDays > 7)
            {
                Console.WriteLine($"{workplaceOneDays} is invalid number.");
                System.Environment.Exit(0);
            }
            

            for (int i = 1; i <= workplaceOneDays; i++)
            {
                string workplaceOneDayName = Console.ReadLine();

                if ((workplaceOneDayName == vibeCheckDay) && (vibeCheckHour >= 16 && vibeCheckHour <= 22))
                    isFree = false;
            }

            if (isFree == true)
            {
                if ((vibeCheckDay == "Tuesday") && (vibeCheckHour >= 10 && vibeCheckHour <= 15))
                    isFree = false;
                else if ((vibeCheckDay == "Wednesday") && (vibeCheckHour >= 10 && vibeCheckHour <= 15))
                    isFree = false;
                else if ((vibeCheckDay == "Thursday") && (vibeCheckHour >= 10 && vibeCheckHour <= 15))
                    isFree = false;
            }

            if (isFree == false)
                Console.WriteLine($"Maria isn’t free on {vibeCheckDay} at {vibeCheckHour}.");
            else
                Console.WriteLine($"Maria is free on {vibeCheckDay} at {vibeCheckHour}.");
        }
    }
}
