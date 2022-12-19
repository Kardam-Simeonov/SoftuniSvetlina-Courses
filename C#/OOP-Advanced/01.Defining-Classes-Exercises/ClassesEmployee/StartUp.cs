using System;

namespace ClassesEmployee
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var department = new Department();
            int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    var input = Console.ReadLine().Split();
            //    department.Employees.Add(new Employee(input[0], int.Parse(input[1])));
            //}

            //var oldest = department.GetOldest();
            //Console.WriteLine($"{oldest.Name} {oldest.Age}");


        }
    }
}
