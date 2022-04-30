using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class ClubPayment
    {
        public long Id { get; set; }
        public Guid ClubId { get; set; }
        public string UserId { get; set; }
        public int? PaymentType { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public int? PaymentMethod { get; set; }
        public DateTime? PaymentExpiration { get; set; }

        public virtual Club Club { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
