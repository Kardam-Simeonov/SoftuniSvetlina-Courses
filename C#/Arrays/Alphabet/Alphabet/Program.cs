using System;
using System.Linq;

namespace Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare the alphabet array and get user input
            char[] alphabet = new char[26];                    
            string input = Console.ReadLine();

            //Create and integer to keep track of the index in the array
            //Run a for loop through all lowercase ascii values and fill them in the array
            int index = 0; 
            for (int i = 97; i <= 122; i++)
            {
                alphabet[index] = Convert.ToChar(i);
                index++;
            }

            //Run through all letters in the input and get the index of it in the alphabet array
            foreach (char i in input)
                Console.WriteLine($"{i} -> {(String.Join(" ", alphabet).IndexOf(i)) / 2}");
        }
    }
}
