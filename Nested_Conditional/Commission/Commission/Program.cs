using System;

namespace Commission
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0.00;

            if (city == "sofia")
            {
                if (sales >= 0 && sales <= 500)
                    commission = 0.05;
                else if (sales >= 500 && sales <= 1000)
                    commission = 0.07;
                else if (sales >= 1000 && sales <= 10000)
                    commission = 0.08;
                else if (sales > 10000)
                    commission = 0.12;

            }
            else if (city == "varna")
            {
                if (sales >= 0 && sales <= 500)
                    commission = 0.045;
                else if (sales >= 500 && sales <= 1000)
                    commission = 0.075;
                else if (sales >= 1000 && sales <= 10000)
                    commission = 0.10;
                else if (sales > 10000)
                    commission = 0.13;

            }
            else if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                    commission = 0.055;
                else if (sales >= 500 && sales <= 1000)
                    commission = 0.08;
                else if (sales >= 1000 && sales <= 10000)
                    commission = 0.12;
                else if (sales > 10000)
                    commission = 0.145;

            }


            if ((city == "sofia" || city == "varna" || city == "plovdiv") && (sales > 0))
            Console.WriteLine($"{sales * commission:F2}");
            else
                Console.WriteLine("error");


        }
    }
}
