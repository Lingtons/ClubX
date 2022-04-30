using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class AppLookup
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string ValueText { get; set; }
        public string Group { get; set; }
    }
}
