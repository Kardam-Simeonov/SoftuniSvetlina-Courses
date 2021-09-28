namespace StudentsGrade
{
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double grade { get; set; }

        public Student(string inputFirstName, string inputLastName, double inputGrade)
        {
            firstName = inputFirstName;
            lastName = inputLastName;
            grade = inputGrade;
        }


    }
}