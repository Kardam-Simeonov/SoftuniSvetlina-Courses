using System.Text;

namespace Person1
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format($"Name: {this.Name}, Age: {this.Age}"));

            return sb.ToString();
        }
    }
}