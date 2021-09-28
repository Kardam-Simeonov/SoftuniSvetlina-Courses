using System;

namespace Exam_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int studentHour = int.Parse(Console.ReadLine());
            int studentMinute = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinute;                   // turns the two ints into minutes
            int studentTime = studentHour * 60 + studentMinute;          //

            int minuteDifference = studentTime - examTime;     // difference between the two


            if (minuteDifference < -30)                 //check if early, on time or late
                Console.WriteLine("Early");
            else if (minuteDifference <= 0)
                Console.WriteLine("On Time");
            else
                Console.WriteLine("Late");
            

            if (minuteDifference != 0)                              // calculates the difference if there is one
            {
                int hours = Math.Abs(minuteDifference / 60);     // from the combined time, takes the hour
                int minutes = Math.Abs(minuteDifference % 60);     //from the calculated time, takes the remainder - minutes


                if (hours > 0)                                            // if there is an hour differece
                {
                    if (minutes < 10)
                        Console.WriteLine($"{hours}:0{minutes} hours");
                    else
                        Console.WriteLine($"{hours}:{minutes} hours");
                }

                else
                    Console.WriteLine($"{minutes} minutes");

                if (minuteDifference < 0)
                    Console.WriteLine("before the start");
                else
                    Console.WriteLine("after the start");

            }
        }
    }
}
            


           

            
