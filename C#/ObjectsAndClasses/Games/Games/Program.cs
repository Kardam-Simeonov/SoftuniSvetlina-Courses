using System;
using System.Collections.Generic;
using System.Linq;

namespace Games
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Squad> squadList = new List<Squad>();
            List<Squad> detachedSquads = new List<Squad>();

            for (int i = 0; i < n; i++)
            {
                string[] initialInput = Console.ReadLine().Split("-");

                if (squadList.Any(x => x.SquadName == initialInput[1]))
                {
                    Console.WriteLine("That squad name is already taken.");
                }
                else if (squadList.Any(x => x.PlayerList.Contains(initialInput[0])))
                {
                    Console.WriteLine($"{initialInput[0]} cannot set up another squad.");
                }
                else
                {
                    squadList.Add(new Squad(initialInput[0], initialInput[1]));
                    Console.WriteLine($"{initialInput[0]} has successfully created a new squad: {initialInput[1]}");
                }
            }   

            string[] input = Console.ReadLine().Split("/");

            while (input[0] != "end")
            {
                if (squadList.Any(x => x.SquadName == input[1]))
                {
                    if (squadList.Where(x => x.SquadName == input[1]).First().PlayerList.Contains(input[0])) //Player is member
                    {
                        Console.WriteLine("The player is already member of a squad.");
                    }
                    else //Player isnt member of current Squad
                    {
                        if (squadList.Any(x => x.PlayerList.Contains(input[0])))
                            squadList.Where(x => x.PlayerList.Contains(input[0])).First().PlayerList.Remove(input[0]);

                        squadList.Where(x => x.SquadName == input[1]).First().PlayerList.Add(input[0]);
                    }
                }
                else
                {
                    Console.WriteLine("The squad doesn't exist.");
                }

                input = Console.ReadLine().Split("/");
            }

            foreach (var squad in squadList.OrderByDescending(x => x.PlayerList.Count))
            {
                if (squad.PlayerList.Count == 1)
                {
                    detachedSquads.Add(squad);
                    squadList.Remove(squad);
                }
                else
                {
                    Console.WriteLine(squad.SquadName);
                    Console.WriteLine($"* {squad.PlayerList[0]}");
                    for (int i = 1; i < squad.PlayerList.Count; i++)
                    {
                        Console.WriteLine($"** {squad.PlayerList[i]}");
                    }
                }
            }

            Console.WriteLine("Squads to detach:");
            //detachedSquads.ForEach(x => Console.WriteLine(x.SquadName));
            foreach (var detached in detachedSquads.OrderBy(x => x.SquadName))
            {
                Console.WriteLine(detached.SquadName);
            }
        }
    }
}
