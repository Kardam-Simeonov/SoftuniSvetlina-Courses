using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyHierarchy
{
    public class Engineer : IEmployee
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

        private decimal salary = 1300;
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private int yearsService;

        public int YearsService
        {
            get { return yearsService; }
            set { yearsService = value; }
        }

        public Engineer(string firstName, string lastName, string department, int yearsService)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Department = department;
            this.YearsService = yearsService;
        }

        public decimal GetSalary()
        {
            return 1300 + 90 * YearsService;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} from {Department} has {YearsService} years of service.";
        }
    }
}
