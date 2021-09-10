using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintCharacters(firstChar, secondChar);

        }

        static void PrintCharacters(char firstChar, char secondChar)
        {
            if (firstChar < secondChar)
                for (int i = Convert.ToInt32(firstChar) + 1; i < Convert.ToInt32(secondChar); i++)
                    Console.Write($"{Convert.ToChar(i)} ");
            else
                for (int i = Convert.ToInt32(secondChar) + 1; i < Convert.ToInt32(firstChar); i++)
                    Console.Write($"{Convert.ToChar(i)} ");

        }
    }
}
