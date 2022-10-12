using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        public string? Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual HashSet<Student>? Students { get; set; }
        public virtual HashSet<Resource>? Resources { get; set; }
        public virtual HashSet<Homework>? Homeworks { get; set; }

        public Course()
        {
            Students = new HashSet<Student>();
            Resources = new HashSet<Resource>();
            Homeworks = new HashSet<Homework>();
        }

    }
}