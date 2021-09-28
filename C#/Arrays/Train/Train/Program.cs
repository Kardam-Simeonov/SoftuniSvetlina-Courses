using System;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] people = new int[n];

            for (int i = 0; i < n; i++)
                people[i] = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Join(" ", people));

            Console.WriteLine(people.Sum());

            
        }
    }
}
