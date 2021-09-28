using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int reachedTargets = 0;
            double originalPower = pokePower;

            while (pokePower >= distance)
            {
                if (pokePower == originalPower / 100 * 50)
                {
                    pokePower /= exhaustionFactor;
                    continue;
                }
                pokePower -= distance;
                reachedTargets++;
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(reachedTargets);
        }
    }
}
