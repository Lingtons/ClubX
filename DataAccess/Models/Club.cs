using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class Club
    {
        public Club()
        {
            ClubPayments = new HashSet<ClubPayment>();
            ClubSchedules = new HashSet<ClubSchedule>();
            LnkClubUsers = new HashSet<LnkClubUser>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool HasMembershipFee { get; set; }
        public double? Amount { get; set; }

        public virtual ICollection<ClubPayment> ClubPayments { get; set; }
        public virtual ICollection<ClubSchedule> ClubSchedules { get; set; }
        public virtual ICollection<LnkClubUser> LnkClubUsers { get; set; }
    }
}
