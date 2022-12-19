namespace DefiningClasses
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public Employee(string inputName, decimal inputSalary, string inputPosition, string inputDepartment)
        {
            Name = inputName;
            Salary = inputSalary;
            Position = inputPosition;
            Department = inputDepartment;
            Email = "n/a";
            Age = -1;
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}