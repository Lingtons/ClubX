using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class ClubSchedule
    {
        public ClubSchedule()
        {
            LnkClubScheduleUsers = new HashSet<LnkClubScheduleUser>();
        }

        public long Id { get; set; }
        public long? LocationId { get; set; }
        public Guid ClubId { get; set; }
        public int ClubDay { get; set; }
        public int ClubStartTime { get; set; }
        public int ClubEndTime { get; set; }
        public string SessionTitle { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Capacity { get; set; }
        public bool Virtual { get; set; }
        public string VirtualLink { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Club Club { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<LnkClubScheduleUser> LnkClubScheduleUsers { get; set; }
    }
}
