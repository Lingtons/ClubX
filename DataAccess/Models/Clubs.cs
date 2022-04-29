using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class Clubs
    {
        public Clubs()
        {
            ClubPayments = new HashSet<ClubPayments>();
            ClubSchedules = new HashSet<ClubSchedules>();
            LnkClubUser = new HashSet<LnkClubUser>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool HasMembershipFee { get; set; }

        public virtual ICollection<ClubPayments> ClubPayments { get; set; }
        public virtual ICollection<ClubSchedules> ClubSchedules { get; set; }
        public virtual ICollection<LnkClubUser> LnkClubUser { get; set; }
    }
}
