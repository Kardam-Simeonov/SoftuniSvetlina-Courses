using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data.Models
{
    public class Student
    {
        [Key] 
        public int StudentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        [StringLength(10)]
        public string? PhoneNumber { get; set; }

        [Required]
        public DateTime RegisteredOn { get; set; }

        public DateTime? Birthday { get; set; }

        public virtual HashSet<Course>? Courses { get; set; }
        public virtual HashSet<Homework>? Homeworks { get; set; }

        public Student()
        {
            Courses = new HashSet<Course>();
            Homeworks = new HashSet<Homework>();
        }
    }
}
