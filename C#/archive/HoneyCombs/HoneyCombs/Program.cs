using System;

namespace HoneyCombs
{
    class Program
    {
        static void Main(string[] args)
        {
            //The following two variables hold the value for number of bees 
            // and number of flowers, filled by the user
            double bees = double.Parse(Console.ReadLine());
            double flowers = double.Parse(Console.ReadLine());

            
            double honeyGrams = bees * flowers * 0.21; //this variable calculates the grams of honey
            double honeyCombs = Math.Floor(honeyGrams / 100); //this variable calculates the number of honeycombs filled
            double honeyLeft = honeyGrams % 100; //this variable calculates the grams of honey leftover

            Console.WriteLine($"{honeyCombs} honeycombs filled.");    //prints out the number of honeycombs filled
            Console.WriteLine($"{honeyLeft:f2} grams of honey left."); //prints out the grams of honey left


        }
    }
}
