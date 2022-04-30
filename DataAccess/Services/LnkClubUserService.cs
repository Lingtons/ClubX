using DataAccess.IServices;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class LnkClubUserService : IService<LnkClubUser>
    {
        readonly ClubxContext _context = new();

        public void Create(LnkClubUser obj)
        {
            _context.LnkClubUsers.Add(obj);
            _context.SaveChanges();
        }

        public IQueryable<LnkClubUser> GetAll()
        {
            return _context.LnkClubUsers;
        }

        public LnkClubUser Get(int id)
        {
            return _context.LnkClubUsers.FirstOrDefault(e => e.Id == id);
        }

        public LnkClubUser Get(Guid guid)
        {
            throw new NotImplementedException();
        }


        public void Delete(LnkClubUser obj)
        {
            var el = _context.LnkClubUsers.FirstOrDefault(e => e.Id == obj.Id);
            _context.LnkClubUsers.Remove(el);
            _context.SaveChanges();

        }

        public void Update(LnkClubUser obj)
        {
            var old = _context.LnkClubUsers.FirstOrDefault(e => e.Id == obj.Id);
            _context.Entry(old).CurrentValues.SetValues(obj);
            _context.SaveChanges();
        }
    }
}
