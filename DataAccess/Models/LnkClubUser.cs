using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class LnkClubUser
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public Guid ClubId { get; set; }

        public virtual Clubs Club { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
