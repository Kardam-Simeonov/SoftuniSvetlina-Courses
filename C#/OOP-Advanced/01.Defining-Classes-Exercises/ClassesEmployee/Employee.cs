using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesEmployee
{
	public class Employee
    {
        private string _name;
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Employee()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Employee(int age) : this()
        {
            this.Age = age;
        }

        public Employee(string name, int age) : this(age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
