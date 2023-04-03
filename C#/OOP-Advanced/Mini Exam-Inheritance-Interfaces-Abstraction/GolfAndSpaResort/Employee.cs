using System;
using System.Collections.Generic;
using System.Text;

namespace GolfAndSpaResort
{
    internal class Employee : IPerson
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

		private int employeeId;

		public int EmployeeId
		{
			get { return employeeId; }
			set { employeeId = value; }
		}

		public Employee(string firstName, string lastName, string department, int employeeId)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Department = department;
			this.EmployeeId = employeeId;
		}

		public void StartWorkingDay()
		{
			Console.WriteLine($"{FirstName} {LastName} with id {EmployeeId} starts a new working day in the department {Department}.");
		}

	}
}
