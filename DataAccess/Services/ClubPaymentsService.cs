using DataAccess.IServices;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class ClubPaymentsService : IService<ClubPayment>
    {
        readonly ClubxContext _context = new();

        public void Create(ClubPayment obj)
        {
            _context.ClubPayments.Add(obj);
            _context.SaveChanges();
        }

        public IQueryable<ClubPayment> GetAll()
        {
            return _context.ClubPayments;
        }

        public ClubPayment Get(int id)
        {
            return _context.ClubPayments.FirstOrDefault(e => e.Id == id);
        }

        public ClubPayment Get(Guid guid)
        {
            throw new NotImplementedException();
        }


        public void Delete(ClubPayment obj)
        {
            var el = _context.ClubPayments.FirstOrDefault(e => e.Id == obj.Id);
            _context.ClubPayments.Remove(el);
            _context.SaveChanges();

        }

        public void Update(ClubPayment obj)
        {
            var old = _context.ClubPayments.FirstOrDefault(e => e.Id == obj.Id);
            _context.Entry(old).CurrentValues.SetValues(obj);
            _context.SaveChanges();
        }
    }
}
