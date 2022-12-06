using System;
using System.Collections.Generic;

namespace VendingMachines.Models
{
    public partial class Machine
    {
        public int Id { get; set; }
        public DateTime? DateOfPlacement { get; set; }
        public string? Type { get; set; }
        public string? Latitude { get; set; }
        public string? Logitude { get; set; }
    }
}
