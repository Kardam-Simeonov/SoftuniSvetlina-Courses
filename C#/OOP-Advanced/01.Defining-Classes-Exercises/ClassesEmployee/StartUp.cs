using System;
using System.Linq;

namespace ClassesEmployee
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var department = new Department();
            int n = int.Parse(Console.ReadLine());

            OpinionPoll(n, department);
        }
        
        private static void OldestEmployee(int n, Department department)
        {
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                department.Employees.Add(new Employee(input[0], int.Parse(input[1])));
            }

            var oldest = department.GetOldest();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");

        }

        private static void OpinionPoll(int n, Department department)
        {
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                department.Employees.Add(new Employee(input[0], int.Parse(input[1])));
            }

            foreach (var employee in department.Employees.OrderBy(e => e.Name).Where(e => e.Age > 30))
                Console.WriteLine($"{employee.Name} - {employee.Age}");
        }
    }
}
