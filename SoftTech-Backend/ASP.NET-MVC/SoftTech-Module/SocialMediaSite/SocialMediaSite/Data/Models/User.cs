using System;
using System.Collections.Generic;

namespace SocialMediaSite.Data.Models
{
    public partial class User
    {
        public int? Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } = null!;
        public string? FirstName { get; set; } = null!;
        public string? LastName { get; set; } = null!;
        public int? Age { get; set; }
        public string? Gender { get; set; } = null!;
    }
}
