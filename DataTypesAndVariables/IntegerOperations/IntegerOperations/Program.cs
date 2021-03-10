using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());


            Console.WriteLine(((numOne + numTwo) / numThree) * numFour);
        }
    }   
}
