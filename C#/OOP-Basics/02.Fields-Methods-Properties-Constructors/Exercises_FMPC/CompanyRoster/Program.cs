using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Department> departments = new List<Department>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                Employee currentEmployee = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3]);

                if (input.Length == 6)
                {
                    currentEmployee.Email = input[4];
                    currentEmployee.Age = int.Parse(input[5]);
                }
                else if (input.Length == 5)
                {
                    currentEmployee.Email = input[4];
                }


                if (departments.Any(x => x.Name == input[3]))
                {
                    departments.Where(x => x.Name == input[3]).First().Employees.Add(currentEmployee);
                    departments.Where(x => x.Name == input[3]).First().SalarySum += decimal.Parse(input[1]);
                }
                else
                {
                    departments.Add(new Department(input[3], new List<Employee> { currentEmployee }, decimal.Parse(input[1])));
                }
            }


            
            Console.WriteLine($"Highest Average Salary: {departments.OrderByDescending(x => x.SalarySum / x.Employees.Count).First().Name}");
            foreach (var employee in departments.OrderByDescending(x => x.SalarySum / x.Employees.Count).First().Employees.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}
