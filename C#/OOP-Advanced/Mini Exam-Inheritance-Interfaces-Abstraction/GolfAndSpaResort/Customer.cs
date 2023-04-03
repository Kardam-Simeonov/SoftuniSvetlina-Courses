using System;
using System.Collections.Generic;
using System.Text;

namespace GolfAndSpaResort
{
    public abstract class Customer : IPerson
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

		public Customer(string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}
	}
}
