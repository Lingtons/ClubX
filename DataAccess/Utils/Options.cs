using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Utils
{
    public static class Options
    {
        readonly static ClubxContext _context = new();

        public static IEnumerable<AppLookup> GetLookups(string category)
        {
            return _context.AppLookups.Where(e => e.Category == category).AsEnumerable();
        }

    }
}
