using DataAccess.IServices;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class LnkClubScheduleUserService : IService<LnkClubScheduleUser>
    {
        readonly ClubxContext _context = new();

        public void Create(LnkClubScheduleUser obj)
        {
            obj.CreatedAt = DateTime.Now;
            _context.LnkClubScheduleUsers.Add(obj);
            _context.SaveChanges();
        }

        public IQueryable<LnkClubScheduleUser> GetAll()
        {
            return _context.LnkClubScheduleUsers;
        }

        public LnkClubScheduleUser Get(int id)
        {
            return _context.LnkClubScheduleUsers.FirstOrDefault(e => e.Id == id);
        }

        public LnkClubScheduleUser Get(Guid guid)
        {
            throw new NotImplementedException();
        }


        public void Delete(LnkClubScheduleUser obj)
        {
            var el = _context.LnkClubScheduleUsers.FirstOrDefault(e => e.Id == obj.Id);
            _context.LnkClubScheduleUsers.Remove(el);
            _context.SaveChanges();

        }

        public void Update(LnkClubScheduleUser obj)
        {
            var old = _context.LnkClubScheduleUsers.FirstOrDefault(e => e.Id == obj.Id);
            _context.Entry(old).CurrentValues.SetValues(obj);
            _context.SaveChanges();
        }
    }
}
