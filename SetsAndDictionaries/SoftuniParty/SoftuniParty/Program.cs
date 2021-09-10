using System;
using System.Collections.Generic;

namespace SoftuniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();

            string input = Console.ReadLine();
            bool startRemoving = false;


            while (input != "END")
            {
                if (input == "PARTY")
                {
                    startRemoving = true;
                    continue;
                }

                if (startRemoving)
                    guests.Remove(input);
                else
                    guests.Add(input);

                input = Console.ReadLine();
            }
        }
    }
}
