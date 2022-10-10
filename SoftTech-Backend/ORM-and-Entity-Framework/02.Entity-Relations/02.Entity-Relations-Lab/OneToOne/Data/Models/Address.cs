using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne.Data.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Text { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
    }
}
