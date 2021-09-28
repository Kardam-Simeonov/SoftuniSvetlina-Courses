using System;
using System.Linq;

namespace EncryptSortAndPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] array = new string[n];
            int[] encrypted = new int[n];

            for (int i = 0; i < n; i++)
                array[i] = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                string currentElement = array[i];
                int vowelSum = 0;
                int consonantSum = 0;
                for (int j = 0; j < currentElement.Length; j++)
                {
                    if ("aeiouAEIOU".IndexOf(currentElement[j]) >= 0)
                        vowelSum += currentElement[j] * currentElement.Length;
                    else
                        consonantSum += currentElement[j] / currentElement.Length;
                }

                encrypted[i] = vowelSum + consonantSum;
            }

            Array.Sort(encrypted);
            Console.WriteLine(string.Join("\n" , encrypted));
        }
    }
}
