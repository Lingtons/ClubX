using DataAccess.IServices;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class ClubsService : IService<Club>
    {
        readonly ClubxContext _context = new();

        public void Create(Club obj)
        {
            _context.Clubs.Add(obj);
            _context.SaveChanges();
        }

        public IQueryable<Club> GetAll()
        {
            return _context.Clubs;
        }

        public Club Get(int id)
        {
            throw new NotImplementedException();
        }

        public Club Get(Guid guid)
        {
            return _context.Clubs.FirstOrDefault(e => e.Id == guid);

        }


        public void Delete(Club obj)
        {
            var el = _context.Clubs.FirstOrDefault(e => e.Id == obj.Id);
            _context.Clubs.Remove(el);
            _context.SaveChanges();

        }

        public void Update(Club obj)
        {
            var old = _context.Clubs.FirstOrDefault(e => e.Id == obj.Id);
            _context.Entry(old).CurrentValues.SetValues(obj);
            _context.SaveChanges();
        }
    }
}
