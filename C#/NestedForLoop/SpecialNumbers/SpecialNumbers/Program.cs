using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool isSpecial = true;
            int a;
            int b;
            for (int i = 1111; i < 10000; i++)
            {
                b = i;
                while (b != 0)
                {
                    a = b % 10;
                    if (a == 0)
                    {
                        isSpecial = false;
                        break;

                    }
                    else if (input % a == 0) b = b / 10;
                    else
                    {
                        isSpecial = false;
                        break;
                    }
                    isSpecial = true;
                }
                if (isSpecial == true) Console.Write(i + " ");
            }
        }
    }
}
