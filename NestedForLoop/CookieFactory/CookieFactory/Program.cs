using System;

namespace CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());
            for (int i = 1; i <= batches; i++)
            {
                bool flour = false;
                bool eggs = false;
                bool sugar = false;

                while (true)
                {
                    string product = Console.ReadLine();

                    if (product == "Bake!")
                        if (flour == true && eggs == true && sugar == true)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                            flour = false; eggs = false; sugar = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                            continue;
                        }
                    switch (product)
                    {
                        case "flour":
                            flour = true;
                            break;
                        case "eggs":
                            eggs = true;
                            break;
                        case "sugar":
                            sugar = true;
                            break;
                    }
                }
            }
        }
    }
}
