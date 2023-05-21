using System;
using System.Text;

namespace ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Predicate<int> predicate = x =>
            {
                foreach (var divider in dividers)
                {
                    if (x % divider != 0)
                    {
                        return false;
                    }
                }

                return true;
            };

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                if (predicate(i))
                {
                    sb.Append(i + " ");
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
