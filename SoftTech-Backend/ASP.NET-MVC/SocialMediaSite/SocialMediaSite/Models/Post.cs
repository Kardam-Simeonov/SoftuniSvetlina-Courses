using System;
using System.Collections.Generic;

namespace SocialMediaSite.Models
{
    public partial class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
