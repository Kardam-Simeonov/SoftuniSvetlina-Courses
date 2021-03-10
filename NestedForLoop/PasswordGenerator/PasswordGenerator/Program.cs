using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            int symOne = 1;
            int symTwo = 1;
            int symThree = 097;
            int symFour = 1;
            int symFive = 1;

            for (int a = 1; a < n; a++)
            {
                symOne = a;
                for (int b = 1; a < n; a++)
                {
                    symTwo = b;
                    for (int c = 1; a < l; a++)
                    {
                        symThree = c;
                        for (int d = 1; a < l; a++)
                        {
                            symFour = d;
                            for (int e = 1; a < n; a++)
                            {
                                if ((e > a) && (e > b))
                                    symFive = e;

                                Console.WriteLine($"{symOne}{symTwo}{(char)(symThree)}{(char)(symFour)}{symFive}");
                            }
                        }
                    }
                }
            }

         
        }
    }
}
