using System;
using System.Collections.Generic;

namespace Grades.Data.Models
{
    public partial class Grade
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Class { get; set; }
        public string? Subject { get; set; }
        public decimal? StudentGrade { get; set; }
    }
}
