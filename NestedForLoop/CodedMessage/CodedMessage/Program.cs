using System;

namespace CodedMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == '0')
                {
                    Console.WriteLine("ZERO");
                    continue;
                }

                int asciiCode = Int32.Parse(input[i].ToString()) + 33;

                char character = Convert.ToChar(asciiCode);

                for (int j = 1; j <= Int32.Parse(input[i].ToString()); j++)
                    Console.Write(character);

                Console.WriteLine();
            }
        }
    }
}
