using DataAccess.IServices;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class PlacesService : IService<Place>
    {
        readonly ClubxContext _context = new();

        public void Create(Place obj)
        {
            _context.Places.Add(obj);
            _context.SaveChanges();
        }

        public IQueryable<Place> GetAll()
        {
            return _context.Places;
        }

        public Place Get(int id)
        {
            return _context.Places.FirstOrDefault(e => e.Id == id);
        }

        public Place Get(Guid guid)
        {
            throw new NotImplementedException();
        }


        public void Delete(Place obj)
        {
            var el = _context.Places.FirstOrDefault(e => e.Id == obj.Id);
            _context.Places.Remove(el);
            _context.SaveChanges();

        }

        public void Update(Place obj)
        {
            var old = _context.Places.FirstOrDefault(e => e.Id == obj.Id);
            _context.Entry(old).CurrentValues.SetValues(obj);
            _context.SaveChanges();
        }
    }
}
