using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToMany.Data.Model
{
    public class Grade
    {
        [Key]
        [ForeignKey("Student")]
        public int GradeId { get; set; }

        [MaxLength(80)]
        public string GradeName { get; set; }

        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}