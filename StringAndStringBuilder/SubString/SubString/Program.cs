using System;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine().ToLower();
            string input = Console.ReadLine();

            CheckOccurencesAndRemove(input, keyword);
        }

        static void CheckOccurencesAndRemove(string input, string keyword)
        {
            int index = input.IndexOf(keyword);


            while (index != -1)
            {
                input = input.Remove(index, keyword.Length);
                index = input.IndexOf(keyword);
            }

            Console.WriteLine(input);
        }
    }
}
