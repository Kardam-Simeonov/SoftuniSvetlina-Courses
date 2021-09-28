using System;
using System.Numerics;

namespace ExampleForObjectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Dices
            Dice diceD6 = new Dice();

            Dice diceD8 = new Dice(8);

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(diceD6.Roll());
            }

            //Using BigInteger
            int number = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);


            //Creating Students
            Student student1 = new Student();
            student1.Name = "Elena";
            student1.LastName = "Barutchieva";
            student1.Age = 25;

            Console.WriteLine(student1.FullName);
            student1.Print();

            Student student2 = new Student();
            student2.Name = "Aleko";
            student2.LastName = "Neshev";
            student2.Age = 15;

            student2.Print();
        }
    }
}
