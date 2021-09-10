using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> times = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (times.ContainsKey(num))
                    times[num]++;
                else
                    times.Add(num, 1);
            }

            foreach (var item in times.Where(x => x.Value % 2 == 0))
            {
                Console.WriteLine(item.Key);
            }
            
        }
    }
}
