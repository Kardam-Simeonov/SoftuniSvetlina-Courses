using System;
using System.Text;
using System.Text.RegularExpressions;

namespace StringExcersices
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckOccurences("One is Two is Three is Four", "is");
        }

        static void ReverseString(string inputString)
        {
            StringBuilder reversedString = new StringBuilder(inputString.Length);

            for (int i = inputString.Length - 1; i >= 0; i--)
                reversedString.Append(inputString[i]);

            Console.WriteLine(reversedString);
        }

        static void CheckBrackets(string input)
        {
            int openingBracketCount = 0;
            int closingBrackedCount = 0;
            foreach (char character in input)
            {
                switch (character)
                {
                    case '(':
                        openingBracketCount++;
                        break;
                    case ')':
                        closingBrackedCount++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(openingBracketCount == closingBrackedCount);
        }

        static void CheckOccurences(string input, string keyword)
        {
            int index = input.IndexOf(keyword);
            int count = 0;

            while (index != -1)
            {
                count++;
                index = input.IndexOf(keyword, index + 1);
            }

            Console.WriteLine(count);
        }

        /*/
        static void ReplaceCase(string input)
        {
            StringBuilder capitalizedString = new StringBuilder(input.Length);
            capitalizedString.Append(input);

            int startingIndex = input.IndexOf('[');
            int lastIndex = input.IndexOf(']');

            while (startingIndex != -1 && lastIndex != -1)
            {
                for (int i = startingIndex; i < lastIndex; i++)
                {
                    Console.WriteLine(startingIndex);
                    Console.WriteLine(lastIndex);
                    capitalizedString.Replace(capitalizedString[i], char.ToUpper(input[i]));
                }

                Console.WriteLine("Escaped");
                startingIndex = input.IndexOf('[', startingIndex + 1);
                lastIndex = input.IndexOf(']', lastIndex + 1);
            }


            Console.WriteLine(capitalizedString);
        }
        /*/

        static void Capitals(string text)
        {
            StringBuilder cap = new StringBuilder(text.Length);
            bool isCapital = false;
            foreach (char symbol in text)
            {
                if (symbol == '[')
                {
                    isCapital = true;
                }
                else if (symbol == ']')
                {
                    isCapital = false;
                }
                else
                {
                    if (isCapital)
                    {
                        cap.Append(char.ToUpper(symbol));
                    }
                    else
                    {
                        cap.Append(symbol);
                    }
                }
            }
            Console.WriteLine(cap);
        }

        static void FillTo20Characters(string input)
        {
            StringBuilder text = new StringBuilder(20);
            text.Append(input);

            int len = 20 - text.Length;

            for (int i = 1; i <= len; i++)
            {
                text.Append('*');
            }

            Console.WriteLine(text);
        }
    }
}
