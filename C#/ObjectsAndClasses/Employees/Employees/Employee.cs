namespace Employees
{
    internal class Employee
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
}