using System;
using System.Collections.Generic;

namespace SocialMediaSite.Models
{
    public partial class DirectMessage
    {
        public int Id { get; set; }
        public string Message { get; set; } = null!;
        public int? SenderId { get; set; }
        public int? RecieverId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual User? Reciever { get; set; }
        public virtual User? Sender { get; set; }
    }
}
