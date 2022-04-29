using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class Places
    {
        public Places()
        {
            ClubSchedules = new HashSet<ClubSchedules>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public virtual ICollection<ClubSchedules> ClubSchedules { get; set; }
    }
}
