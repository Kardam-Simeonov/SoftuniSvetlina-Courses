using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int units, tens, hundreds;
            int coins = 0;

            num *= 100;

            units = (int)(num % 10);
            tens = (int)((num / 10) % 10);
            hundreds = (int)((num / 100) % 10);


            if (hundreds >= 5)
            {
                hundreds -= 5;
                coins++;
            }
            if (hundreds >= 2)
            {
                coins += hundreds % 2;
                hundreds -= hundreds % 2;

                coins += hundreds / 2;
            }
            else
                coins += hundreds;
   


            if (tens >= 5)
            {
                tens -= 5;
                coins++;
            }
            if (tens >= 2)
            {
                coins += tens % 2;
                tens -= tens % 2;

                coins += tens / 2;
            }
            else
                coins += tens;




            if (units >= 5)
            {
                units -= 5;
                coins++;
            }
            if (units >= 2)
            {
                coins += units % 2;
                units -= units % 2;

                coins += units / 2;
            }
            else
                coins += units;
           
            Console.WriteLine(coins);

        }
    }
}
