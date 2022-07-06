using System;
using System.Collections.Generic;

namespace SocialMediaSite.Data.Models
{
    public partial class DirectMessage
    {
        public int Id { get; set; }
        public string Message { get; set; } = null!;
        public string? SenderName { get; set; }
        public string? RecieverName { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
