using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class ClubSchedule
    {
        public long Id { get; set; }
        public long PlaceId { get; set; }
        public Guid ClubId { get; set; }
        public int ClubDay { get; set; }
        public int ClubStartTime { get; set; }
        public int ClubEndTime { get; set; }

        public virtual Club Club { get; set; }
        public virtual Place Place { get; set; }
    }
}
