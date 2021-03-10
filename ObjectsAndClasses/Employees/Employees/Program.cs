using System;
using System.Collections.Generic;
using System.Linq;

namespace Employees
{
    class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Salary { get; set; }


        public Employee(string userFirstName, string userLastName, double userSalary)
        {
            FirstName = userFirstName;
            LastName = userLastName;
            Salary = userSalary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Employee> employeeList = new List<Employee>();
            for (int i = 1; i <= count; i++)
            {
                string[] input = Console.ReadLine().Split();

                Employee userEmployee = new Employee(input[0], input[1], double.Parse(input[2]));
                employeeList.Add(userEmployee);
            }

            foreach (var employee in employeeList.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.Salary:f2}");
            }
        }
    }
}
