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
        public bool HasClubAdminRole { get; set; }

        public virtual Club Club { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
