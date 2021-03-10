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
}