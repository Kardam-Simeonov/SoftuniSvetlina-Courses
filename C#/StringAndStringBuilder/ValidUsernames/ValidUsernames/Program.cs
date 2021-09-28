using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (string username in usernames)
            {
                if (username.Length > 3 && username.Length < 16)
                {
                    if (username.All(letter => Char.IsLetterOrDigit(letter) || letter == '-' || letter == '_'))
                        Console.WriteLine(username);
                }
            }
        }
    }
}
