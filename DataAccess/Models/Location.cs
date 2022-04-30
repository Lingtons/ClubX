using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class Location
    {
        public Location()
        {
            ClubSchedules = new HashSet<ClubSchedule>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public virtual ICollection<ClubSchedule> ClubSchedules { get; set; }
    }
}
