using System;

namespace StringMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Console.WriteLine(MultiplyStrings(input[0], input[1]));
        }

        static int MultiplyStrings(string firstString, string secondString)
        {
            int result = 0;

            if (firstString.Length > secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    if (i < secondString.Length)
                        result += Convert.ToInt32(firstString[i]) * Convert.ToInt32(secondString[i]);
                    else
                        result += Convert.ToInt32(firstString[i]);
                }
            }

            else
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    if (i < firstString.Length)
                        result += Convert.ToInt32(firstString[i]) * Convert.ToInt32(secondString[i]);
                    else
                        result += Convert.ToInt32(secondString[i]);
                }
            }

            return result;
        }
    }
}
