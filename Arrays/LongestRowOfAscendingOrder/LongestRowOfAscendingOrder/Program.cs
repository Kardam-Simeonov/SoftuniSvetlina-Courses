using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestRowOfAscendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();

            StringBuilder longestRow = new StringBuilder();
            StringBuilder currentRow = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0 || currentRow.Length == 0)
                {
                    currentRow.Append(arr[i].ToString() + " ");
                    continue;
                }

                if (arr[i] == arr[i-1] + 1)
                {
                    currentRow.Append(arr[i].ToString() + " ");
                }
                else
                {
                    if (currentRow.Length > longestRow.Length)
                        longestRow = currentRow;

                    currentRow = new StringBuilder();
                    currentRow.Append(arr[i].ToString() + " ");
                }
            }

            if (longestRow.Length == 0)
                Console.WriteLine(currentRow);
            else
                Console.WriteLine(longestRow);
        }
    }
}
