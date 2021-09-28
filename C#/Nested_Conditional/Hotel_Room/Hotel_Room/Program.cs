using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            double stays = double.Parse(Console.ReadLine());
            double apartPrice = 0.00;
            double studioPrice = 0.00;

            if (month == "may" || month == "october")
            {
                studioPrice = stays * 50;
                apartPrice = stays * 65;

                if (stays > 7 && stays <= 14)
                    studioPrice -= studioPrice * 0.05;
                else if (stays > 14)
                {
                    studioPrice -= studioPrice * 0.30;
                    apartPrice -= apartPrice * 0.10;
                }

            }
            else if (month == "june" || month == "september")
            {
                studioPrice = stays * 75.20;
                apartPrice = stays * 68.70;

                if (stays > 14)
                {
                    studioPrice -= studioPrice * 0.30;
                    apartPrice -= apartPrice * 0.10;
                }
            }
            else if (month == "july" || month == "august")
            {
                studioPrice = stays * 76;
                apartPrice = stays * 77;

                if (stays > 14)
                    apartPrice -= apartPrice * 0.10;
                
            }

            Console.WriteLine($"Apartment: {apartPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
