using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeStatistic
{
    class Employee
    {
        public string Name { get; set; }

        public double Salary { get; set; }

        public string Department { get; set; }


        public Employee(string userName, double userSalary, string userDepartment)
        {
            Name = userName;
            Salary = userSalary;
            Department = userDepartment;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Employee>> departmentList = new Dictionary<string, List<Employee>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                string[] input = Console.ReadLine().Split();

                Employee userEmployee = new Employee(input[0], double.Parse(input[1]), input[2]);

                if (!departmentList.ContainsKey(input[2]))
                {
                    departmentList.Add(input[2], new List<Employee>());
                    departmentList[input[2]].Add(userEmployee);
                }

                else
                {
                    departmentList[input[2]].Add(userEmployee);
                }
            }

            double highestDepartmentSalary = 0;
            string departmentWithSalary = "";

            foreach (var department in departmentList)
            {
                double sum = 0;
                department.Value.ForEach(x => sum += x.Salary);

                if (sum / department.Value.Count > highestDepartmentSalary)
                {
                    highestDepartmentSalary = sum / department.Value.Count;
                    departmentWithSalary = department.Key;
                }
            }

            Console.WriteLine($"Highest Average Salary: {departmentWithSalary}");
            foreach (var employee in departmentList[departmentWithSalary].OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
}
