using System;
using System.Collections.Generic;

namespace ParkingSystem.Models
{
    public partial class Car
    {
        public string Registration { get; set; } = null!;
        public TimeSpan? RegisteredTime { get; set; }
    }
}
