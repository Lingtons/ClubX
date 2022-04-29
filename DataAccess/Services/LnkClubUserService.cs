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

        public void Creat(LnkClubUser obj)
        {
            _context.LnkClubUser.Add(obj);
            _context.SaveChanges();
        }

        public IQueryable<LnkClubUser> GetAll()
        {
            return _context.LnkClubUser;
        }

        public LnkClubUser Get(int id)
        {
            return _context.LnkClubUser.FirstOrDefault(e => e.Id == id);
        }

        public LnkClubUser Get(Guid guid)
        {
            throw new NotImplementedException();
        }


        public void Delete(LnkClubUser obj)
        {
            var el = _context.LnkClubUser.FirstOrDefault(e => e.Id == obj.Id);
            _context.LnkClubUser.Remove(el);
            _context.SaveChanges();

        }

        public void Update(LnkClubUser obj)
        {
            var old = _context.LnkClubUser.FirstOrDefault(e => e.Id == obj.Id);
            _context.Entry(old).CurrentValues.SetValues(obj);
            _context.SaveChanges();
        }
    }
}
