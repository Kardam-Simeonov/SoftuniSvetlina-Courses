using System;

namespace VolleyBall
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double festivities = double.Parse(Console.ReadLine());
            double homeComing = double.Parse(Console.ReadLine());

            double homeGames = homeComing;
            double festiveGames = festivities * (0.6666667) ;
            double sofiaGames = (48 - homeComing) * (0.75);

            double totalGames = sofiaGames + homeGames + festiveGames;

            if (yearType == "leap")
            {
                totalGames += totalGames * 0.15;
                Console.WriteLine(Math.Floor(totalGames));
            }
            else if (yearType == "normal")
                Console.WriteLine(Math.Floor(totalGames));



        }
    }
}
