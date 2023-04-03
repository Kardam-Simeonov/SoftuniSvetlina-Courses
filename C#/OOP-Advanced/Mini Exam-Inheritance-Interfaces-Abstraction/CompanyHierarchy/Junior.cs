using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyHierarchy
{
    public class Junior : IEmployee
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

		private decimal salary = 900;

		public decimal Salary
		{
			get { return salary; }
			set { salary = value; }
		}

		public Junior(string firstName, string lastName, string department)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Department = department;
		}

		public decimal GetSalary()
		{
			return Salary;
		}

        public override string ToString()
        {
			return $"{FirstName} {LastName} is {Department} engineer.";
        }
    }
}
