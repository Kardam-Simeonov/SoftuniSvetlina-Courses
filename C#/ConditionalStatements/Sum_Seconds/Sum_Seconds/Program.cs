using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int sum = time1 + time2 + time3;

            int hours = sum / 60;
            int minutes = sum % 60;

            if (hours == 12)
                hours = 0;
            if (minutes < 10)
                Console.WriteLine("{0}:0{1}", hours, minutes);
            else
                Console.WriteLine("{0}:{1}", hours, minutes);



        }
    }
}
