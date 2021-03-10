using System;

namespace RandomStringOfN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] randomString = new char[n];
            Console.WriteLine(String.Join(' ', GenerateRandomString(randomString)).Replace(" ", ""));
        }

        static char[] GenerateRandomString(char[] randomString)
        {
            Random rand = new Random();
            for (int i = 0; i < randomString.Length; i++)
            {
                randomString[i] = (char)rand.Next(97, 122);
            }

            return randomString;
        }
    }
}
