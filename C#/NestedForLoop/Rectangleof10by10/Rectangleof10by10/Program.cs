using System;

namespace Rectangleof10by10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(new string('*', 10));
        }
    }
}
