using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class ClubSchedules
    {
        public long Id { get; set; }
        public long PlaceId { get; set; }
        public string ClubId { get; set; }
        public int ClubDay { get; set; }
        public int ClubStartTime { get; set; }
        public int ClubEndTime { get; set; }

        public virtual Clubs Club { get; set; }
        public virtual Places Place { get; set; }
    }
}
