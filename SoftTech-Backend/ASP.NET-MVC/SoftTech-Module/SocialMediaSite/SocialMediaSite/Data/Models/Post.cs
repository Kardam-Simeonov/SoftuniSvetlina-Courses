using System;
using System.Collections.Generic;

namespace SocialMediaSite.Data.Models
{
    public partial class Post
    {
        public string Title { get; set; } = null!;
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Username { get; set; }
    }
}
