using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1Drivers
{
    public class Driver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double TotalTime { get; set; }
        public double Speed { get; set; }

        public Driver(string name, int age, double totalTime, double speed)
        {
            this.Name = name;
            this.Age = age;
            this.TotalTime = totalTime;
            this.Speed = speed;
        }
    }
}
