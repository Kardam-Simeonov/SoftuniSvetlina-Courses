using System;

namespace MrandMrs
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            if (gender == 'm')
            {
                if (age >= 16)
                    Console.WriteLine("Mr.");
                else
                    Console.WriteLine("Master");
            }

            if (gender == 'f')
            {
                if (age >= 16)
                    Console.WriteLine("Ms.");
                else
                    Console.WriteLine("Miss");
            }
        }
    }
}
