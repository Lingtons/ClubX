using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class LnkClubScheduleUser
    {
        public long Id { get; set; }
        public long ClubScheduleId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ClubSchedule ClubSchedule { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
