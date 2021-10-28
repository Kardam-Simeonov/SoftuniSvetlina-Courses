using System.Collections.Generic;

namespace DefiningClasses
{
    public class Department
    {
        private string name;
        private List<Employee> employees;
        private decimal salarySum;

        public Department(string name, List<Employee> employees, decimal salarySum)
        {
            Name = name;
            Employees = employees;
            SalarySum = salarySum;
        }
        public decimal SalarySum
        {
            get { return salarySum; }
            set { salarySum = value; }
        }

        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}