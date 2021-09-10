using System;

namespace Concatenations
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = Console.ReadLine();

            string lastName = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            string town = Console.ReadLine();



            Console.Write($"You are {firstName} {lastName}, a {age}-years old person from {town}.");

        }
    }
}
