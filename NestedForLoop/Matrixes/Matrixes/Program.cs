using System;

namespace Matrixes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int FRFN = a; FRFN <= b; FRFN++)
            {
                for (int FRSN = a; FRSN <= b; FRSN++)
                {
                    for (int SRFN = c; SRFN <= d; SRFN++)
                    
                        for (int SRSN = c; SRSN <= d; SRSN++)
                        {
                            if ((FRFN  + SRSN) == (FRSN + SRFN) && (FRFN != FRSN) && (SRFN != SRSN))
                            {
                                Console.WriteLine($"{FRFN}{FRSN}");
                                Console.WriteLine($"{SRFN}{SRSN}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }

