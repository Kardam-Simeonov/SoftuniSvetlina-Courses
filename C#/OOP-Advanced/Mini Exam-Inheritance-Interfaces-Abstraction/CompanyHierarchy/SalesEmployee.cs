using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyHierarchy
{
    public class SalesEmployee : IEmployee
    {
		private string firstName;
		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string lastName;
		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private string department;
		public string Department
		{
			get { return department; }
			set { department = value; }
		}

		private decimal salary = 1000;
		public decimal Salary
		{
			get { return salary; }
			set { salary = value; }
		}

		private decimal profits;
		public decimal Profits
		{
			get { return profits; }
			set { profits = value; }
		}

		public SalesEmployee(string firstName, string lastName, string department, decimal profits)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Department = department;
			this.Profits = profits;
		}

		public decimal GetSalary()
		{
			return (Profits / 100) * 10 + 1000;
		}

        public override string ToString()
        {
			return $"{FirstName} {LastName} from {Department} has {Profits} profits.";
        }
    }
}
