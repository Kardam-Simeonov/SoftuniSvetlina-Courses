using System;

namespace Bonus_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());

            double bonus = 0;

            if (points <= 100)
                bonus += 5;

            else if (points > 100 && points < 1000)
                bonus = bonus + points * 0.20;

            else if (points > 1000)
                bonus = bonus + points * 0.10;

            if (points % 2 == 0)
                bonus += 1;
            else if (points % 5 == 0)
                bonus += 2;

            Console.WriteLine(bonus);
            Console.WriteLine(points + bonus);


        }
    }
}
