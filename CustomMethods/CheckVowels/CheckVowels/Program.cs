using System;

namespace CheckVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintResult(CalculateCountOfVowels(input));
        }

        static int CalculateCountOfVowels(string input)
        {
            int vowelCount = 0;
            for (int i = 0; i <= input.Length - 1; i++)
            {
                switch (input[i])
                {
                    case 'a':
                        vowelCount++;
                        break;
                    case 'e':
                        vowelCount++;
                        break;
                    case 'i':
                        vowelCount++;
                        break;
                    case 'o':
                        vowelCount++;
                        break;
                    case 'u':
                        vowelCount++;
                        break;
                    case 'A':
                        vowelCount++;
                        break;
                    case 'E':
                        vowelCount++;
                        break;
                    case 'I':
                        vowelCount++;
                        break;
                    case 'O':
                        vowelCount++;
                        break;
                    case 'U':
                        vowelCount++;
                        break;
                    default:
                        break;
                }
            }

            return vowelCount;
        }

        static void PrintResult(int vowelCount)
        {
            Console.WriteLine(vowelCount);
        }
    }
}
