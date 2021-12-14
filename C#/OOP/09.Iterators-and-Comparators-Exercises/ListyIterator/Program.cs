using System;
using System.Collections.Generic;

namespace ImplementListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            ListyIterator<string> iterator = new ListyIterator<string>(new List<string>());

            while (input[0] != "END")
            {
                try
                {
                    switch (input[0])
                    {
                        case "Create":
                            for (int i = 1; i < input.Length; i++)
                                iterator.Items.Add(input[i]);
                            break;
                        case "Move":
                            Console.WriteLine(iterator.Move());
                            break;
                        case "HasNext":
                            Console.WriteLine(iterator.HasNext());
                            break;
                        case "Print":
                            iterator.Print();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Operation!");
                }

                input = Console.ReadLine().Split(' '); 
            }
        }
    }
}
