using System.Xml.Serialization;

namespace Employees
{
    public class Employee
    {
        public int Id { get; set; }

        [XmlElement("Name")]
        public string EmployeeName { get; set; }

        [XmlElement("Department")]
        public string DepartmentName { get; set; }
    }
}
