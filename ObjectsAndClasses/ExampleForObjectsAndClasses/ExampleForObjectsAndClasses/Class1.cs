using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleForObjectsAndClasses
{
    class Student
    {
        // Empty Constructor
        public Student()
        {

        }

        //Authomatic Property, only get -> readonly!!
        public string FullName
        {
            get { return this.Name + " " + this.LastName; }
        }

        //Properties with get and set 
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //Method - Action
        public void Print()
        {
            Console.WriteLine($"I am {FullName} and I am {Age} year old");
        }
    }
}
