using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Utils
{
    public static class Utility
    {
        readonly static ClubxContext _context = new();

        public static bool IsMember(Guid clubId, String userId)
        {
            return _context.LnkClubUsers.Any(e => e.ClubId == clubId && e.UserId == userId);
        }

        public static bool IsClubAdmin(Guid clubId, String userId)
        {
            var lnk = _context.LnkClubUsers.FirstOrDefault(e => e.ClubId == clubId && e.UserId == userId);
            if (lnk != null)
            {
                return lnk.HasClubAdminRole;
            }
            return false;
        }

        public static string GetUserNames(string id)
        {
            var user = _context.AspNetUsers.FirstOrDefault(e => e.Id == id);
            if (user != null)
            {
                return String.Format(user?.FirstName+" "+user?.LastName);
            }

            return "";
        } 
    }
}
