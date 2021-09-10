using System;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name comrade");
            string name = Console.ReadLine();
            if (name == "Stalin") {
                Console.WriteLine("Woppaaaa, Hello lord " + name);
            }
            else { 
                Console.WriteLine("Hello comrade " + name);
            }

            string input = Console.ReadLine();
            double num = double.Parse(input);


        }
    }
}
