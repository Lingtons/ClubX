using DataAccess.IServices;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class UserService : IService<AspNetUsers>
    {
        readonly ClubxContext _context = new();

        public void Create(AspNetUsers obj)
        {
            _context.AspNetUsers.Add(obj);
            _context.SaveChanges();
        }

        public IQueryable<AspNetUsers> GetAll()
        {
            return _context.AspNetUsers;
        }

        public AspNetUser Get(int id)
        {
            throw new NotImplementedException();
        }

        public AspNetUsers Get(Guid guid)
        {

            return _context.AspNetUsers.FirstOrDefault(e => e.Id == Convert.ToString(guid));
        }


        public void Delete(AspNetUsers obj)
        {
            var el = _context.AspNetUsers.FirstOrDefault(e => e.Id == obj.Id);
            _context.AspNetUsers.Remove(el);
            _context.SaveChanges();

        }

        public void Update(AspNetUser obj)
        {
            var old = _context.AspNetUsers.FirstOrDefault(e => e.Id == obj.Id);
            _context.Entry(old).CurrentValues.SetValues(obj);
            _context.SaveChanges();
        }
    }
}
