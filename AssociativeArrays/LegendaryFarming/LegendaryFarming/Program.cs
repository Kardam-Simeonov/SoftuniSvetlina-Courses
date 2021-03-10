using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            items.Add("motes", 0);
            items.Add("shards", 0);
            items.Add("fragments", 0);

            while (true)
            {
                string[] loot = Console.ReadLine().Split(" ");
                bool itemFound = false;

                for (int i = 0; i < loot.Length; i += 2)
                {
                    string currentItem = loot[i + 1].ToLower();
                    if (items.ContainsKey(currentItem))
                        items[currentItem] += int.Parse(loot[i]);
                    else
                        items.Add(currentItem, int.Parse(loot[i]));

                    if (items.ContainsKey("shards") && items["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        items["shards"] -= 250;
                        itemFound = true;
                        break;
                    }
                    else if (items.ContainsKey("fragments") && items["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        items["fragments"] -= 250;
                        itemFound = true;
                        break;
                    }
                    else if (items.ContainsKey("motes") && items["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        items["motes"] -= 250;
                        itemFound = true;
                        break;
                    }
                }

                if (itemFound)
                    break;
            }

            Dictionary<string, int> keyItems = new Dictionary<string, int>
            {
                { "motes", items["motes"] },
                { "fragments", items["fragments"] },
                { "shards", items["shards"] }
            };
            

            foreach (var item in keyItems.OrderByDescending(key => key.Value).ThenBy(key => key.Key))
                Console.WriteLine($"{item.Key}: {item.Value}");
            

            items.Remove("motes");
            items.Remove("shards");
            items.Remove("fragments");

            foreach (var item in items.OrderBy(key => key.Key))
                Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
