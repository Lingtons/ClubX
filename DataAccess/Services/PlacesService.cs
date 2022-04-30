using DataAccess.IServices;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class PlacesService : IService<Places>
    {
        readonly ClubxContext _context = new();

        public void Create(Places obj)
        {
            _context.Places.Add(obj);
            _context.SaveChanges();
        }

        public IQueryable<Places> GetAll()
        {
            return _context.Places;
        }

        public Places Get(int id)
        {
            return _context.Places.FirstOrDefault(e => e.Id == id);
        }

        public Places Get(Guid guid)
        {
            throw new NotImplementedException();
        }


        public void Delete(Places obj)
        {
            var el = _context.Places.FirstOrDefault(e => e.Id == obj.Id);
            _context.Places.Remove(el);
            _context.SaveChanges();

        }

        public void Update(Places obj)
        {
            var old = _context.Places.FirstOrDefault(e => e.Id == obj.Id);
            _context.Entry(old).CurrentValues.SetValues(obj);
            _context.SaveChanges();
        }
    }
}
