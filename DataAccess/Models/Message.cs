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
        public string MessageBody { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual AspNetUser Recipient { get; set; }
    }
}
