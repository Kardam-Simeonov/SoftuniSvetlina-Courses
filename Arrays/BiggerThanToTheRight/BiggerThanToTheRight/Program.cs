using System;
using System.Linq;

namespace BiggerThanToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            long [] numbers = Console.ReadLine()    //Get user input and put it in an array
                .Split(" ")
                .Select(long.Parse)
                .ToArray();


            // create an integer to keep track of equal numbers
            // Check if each element of the array is equal to the first 
            int equalNumbers = 0;
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] == numbers[0])
                    equalNumbers++;

            // Check if all elements are equal and bigger than one
            // Print to the console and end the program
            if (equalNumbers >= numbers.Length && numbers.Length > 1)
            {
                Console.WriteLine($"There are {equalNumbers} identical numbers");
                System.Environment.Exit(0);
            }

            // Run through all numbers 
            // Create a boolean to keep track if the number is bigger
            // Run through and compare the current number to all to it's right
            // If it's smaller, set the bool to false
            // Check if the selected number is bigger and print it out
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isHigherThanRest = true;
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    if (numbers[i] <= numbers[k])
                        isHigherThanRest = false;
                }

                if (isHigherThanRest == true)
                    Console.Write($"{numbers[i]} ");
            }
           
        }
    }
}
