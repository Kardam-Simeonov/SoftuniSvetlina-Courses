namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int inputAge) 
            : this()
        {
            Name = "No name";
            Age = inputAge;
        }
        public Person(string inputName, int inputAge) 
            : this(inputAge)
        {
            Name = inputName;
            Age = inputAge;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}