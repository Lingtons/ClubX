using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class Message
    {
        public long Id { get; set; }
        public string SenderId { get; set; }
        public string RecipientId { get; set; }
        public string Message1 { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
