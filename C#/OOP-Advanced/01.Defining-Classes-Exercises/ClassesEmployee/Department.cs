using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesEmployee
{
    public class Department
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public void AddMember(Employee member)
        {
            Employees.Add(member);
        }

        public Employee GetOldest()
        {
            return Employees.OrderByDescending(x => x.Age).First();
        }
    }
}
