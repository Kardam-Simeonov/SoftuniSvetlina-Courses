using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToMany.Data.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [ForeignKey("Grade")]
        public int GradeId { get; set; }

        public Grade Grade { get; set; }
    }
}