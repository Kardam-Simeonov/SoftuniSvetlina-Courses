using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Employees
{
    public class StartUp
    {
        static void Main()
        {
            Console.WriteLine(ReadEmployeesData("../../../XMLData.xml"));
            WriteEmployeesData("../../../ArrayOfEmployees.xml");
        }
        public static string ReadEmployeesData(string path)
        {
            var employees = XDocument.Load(path).Root.Elements();
            StringBuilder result = new StringBuilder();
            foreach (var employee in employees)
            {               
                result.AppendLine($"{employee.Element("Id").Value} {employee.Element("Name").Value} {employee.Element("Department").Value}");
            }
            return result.ToString().TrimEnd();
        }
        
        public static void WriteEmployeesData(string path)
        {
            Employee employee1 = new Employee()
            {
                Id = 1,
                EmployeeName = "Alisa Bell",
                DepartmentName = "Development"
            };
            Employee employee2 = new Employee()
            {
                Id = 2,
                EmployeeName = "Samuel Griffin",
                DepartmentName = "Development"
            };
            Employee employee3 = new Employee()
            {
                Id = 3,
                EmployeeName = "Johnny Garcia",
                DepartmentName = "Development"
            };

            List<Employee> ArrayOfEmployees = new List<Employee>();
            ArrayOfEmployees.Add(employee1);
            ArrayOfEmployees.Add(employee2);
            ArrayOfEmployees.Add(employee3);

            XmlSerializer output = new XmlSerializer(typeof(List<Employee>));
            FileStream stream = File.Create(path);

            output.Serialize(stream, ArrayOfEmployees);

            stream.Close();
        }
    }
}
