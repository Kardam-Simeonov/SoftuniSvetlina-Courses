using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine().ToLower();
            string grade = Console.ReadLine().ToLower();
            double discount = 0.00;
            double cost = 0.00;
            double nights = days - 1;

            if (roomType == "room for one person")
            {
                cost = 18.00 * nights;

                if (grade == "positive")
                    cost += cost * 0.25;
                else if (grade == "negative")
                    cost -= cost * 0.10;
            }

            else if (roomType == "apartment")
            {
                cost = 25.00 * nights;

                if (nights < 10)
                    discount = cost * 0.30;
                else if (nights >= 10 && nights <= 15)
                    discount = cost * 0.35;
                else if (nights > 15)
                    discount = cost * 0.50;

                cost -= discount;

                if (grade == "positive")
                    cost += cost * 0.25;
                else if (grade == "negative")
                    cost -= cost * 0.10;

            }
            else if (roomType == "president apartment")
            {
                cost = 35.00 * nights;

                if (nights < 10)
                    discount = cost * 0.10;
                else if (nights >= 10 && nights <= 15)
                    discount = cost * 0.15;
                else if (nights > 15)
                    discount = cost * 0.20;

                cost -= discount;

                if (grade == "positive")
                    cost += cost * 0.25;
                else if (grade == "negative")
                    cost -= cost * 0.10;

            }

            Console.WriteLine($"{cost:f2}");


        }
    }
}
