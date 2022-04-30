using DataAccess.IServices;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class ClubsService : IService<Clubs>
    {
        readonly ClubxContext _context = new();

        public void Create(Clubs obj)
        {
            _context.Clubs.Add(obj);
            _context.SaveChanges();
        }

        public IQueryable<Clubs> GetAll()
        {
            return _context.Clubs;
        }

        public Clubs Get(int id)
        {
            throw new NotImplementedException();
        }

        public Clubs Get(Guid guid)
        {
            return _context.Clubs.FirstOrDefault(e => e.Id == guid);

        }


        public void Delete(Clubs obj)
        {
            var el = _context.Clubs.FirstOrDefault(e => e.Id == obj.Id);
            _context.Clubs.Remove(el);
            _context.SaveChanges();

        }

        public void Update(Clubs obj)
        {
            var old = _context.Clubs.FirstOrDefault(e => e.Id == obj.Id);
            _context.Entry(old).CurrentValues.SetValues(obj);
            _context.SaveChanges();
        }
    }
}
