using DataAccess.IServices;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class ClubScheduleService : IService<ClubSchedule>
    {
        readonly ClubxContext _context = new();

        public void Create(ClubSchedule obj)
        {
            _context.ClubSchedules.Add(obj);
            _context.SaveChanges();
        }

        public IQueryable<ClubSchedule> GetAll()
        {
            return _context.ClubSchedules;
        }

        public ClubSchedule Get(int id)
        {
            return _context.ClubSchedules.FirstOrDefault(e => e.Id == id);
        }

        public ClubSchedule Get(Guid guid)
        {
            throw new NotImplementedException();
        }


        public void Delete(ClubSchedule obj)
        {
            var el = _context.ClubSchedules.FirstOrDefault(e => e.Id == obj.Id);
            _context.ClubSchedules.Remove(el);
            _context.SaveChanges();

        }

        public void Update(ClubSchedule obj)
        {
            var old = _context.ClubSchedules.FirstOrDefault(e => e.Id == obj.Id);
            _context.Entry(old).CurrentValues.SetValues(obj);
            _context.SaveChanges();
        }
    }
}
