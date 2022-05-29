using System;
using System.Collections.Generic;

namespace SocialMediaSite.Models
{
    public partial class User
    {
        public User()
        {
            DirectMessageRecievers = new HashSet<DirectMessage>();
            DirectMessageSenders = new HashSet<DirectMessage>();
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public string Gender { get; set; } = null!;

        public virtual ICollection<DirectMessage> DirectMessageRecievers { get; set; }
        public virtual ICollection<DirectMessage> DirectMessageSenders { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
