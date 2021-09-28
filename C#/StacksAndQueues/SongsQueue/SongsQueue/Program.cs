using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> Rythm = new Queue<string>();

            string[] input = Console.ReadLine().Split(", ");

            foreach (string song in input)
                Rythm.Enqueue(song);

            while (Rythm.Count() > 0)
            {
                Match command = Regex.Match(Console.ReadLine(), @"(?<action>[A-Za-z]+)( (?<song>.+))*");

                switch (command.Groups["action"].Value)
                {
                    case "Play":
                        Rythm.Dequeue();
                        break;
                    case "Show":
                        Console.WriteLine(String.Join(", ", Rythm));
                        break;
                    case "Add":
                        if (Rythm.Contains(command.Groups["song"].Value))
                            Console.WriteLine($"{command.Groups["song"].Value} is already contained!");
                        else
                            Rythm.Enqueue(command.Groups["song"].Value);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
