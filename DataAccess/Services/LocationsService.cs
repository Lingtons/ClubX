using DataAccess.IServices;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class LocationsService : IService<Location>
    {
        readonly ClubxContext _context = new();

        public void Create(Location obj)
        {
            _context.Locations.Add(obj);
            _context.SaveChanges();
        }

        public IQueryable<Location> GetAll()
        {
            return _context.Locations;
        }

        public Location Get(int id)
        {
            return _context.Locations.FirstOrDefault(e => e.Id == id);
        }

        public Location Get(Guid guid)
        {
            throw new NotImplementedException();
        }


        public void Delete(Location obj)
        {
            var el = _context.Locations.FirstOrDefault(e => e.Id == obj.Id);
            _context.Locations.Remove(el);
            _context.SaveChanges();

        }

        public void Update(Location obj)
        {
            var old = _context.Locations.FirstOrDefault(e => e.Id == obj.Id);
            _context.Entry(old).CurrentValues.SetValues(obj);
            _context.SaveChanges();
        }
    }
}
