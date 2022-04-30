using DataAccess.IServices;
//using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    //public class ClubScheduleService : IService<ClubSchedules>
    //{
    //    readonly ClubxContext _context = new();

    //    public void Create(ClubSchedules obj)
    //    {
    //        _context.ClubSchedules.Add(obj);
    //        _context.SaveChanges();
    //    }

    //    public IQueryable<ClubSchedules> GetAll()
    //    {
    //        return _context.ClubSchedules;
    //    }

    //    public ClubSchedules Get(int id)
    //    {
    //        return _context.ClubSchedules.FirstOrDefault(e => e.Id == id);
    //    }

    //    public ClubSchedules Get(Guid guid)
    //    {
    //        throw new NotImplementedException();
    //    }


    //    public void Delete(ClubSchedules obj)
    //    {
    //        var el = _context.ClubSchedules.FirstOrDefault(e => e.Id == obj.Id);
    //        _context.ClubSchedules.Remove(el);
    //        _context.SaveChanges();

    //    }

    //    public void Update(ClubSchedules obj)
    //    {
    //        var old = _context.ClubSchedules.FirstOrDefault(e => e.Id == obj.Id);
    //        _context.Entry(old).CurrentValues.SetValues(obj);
    //        _context.SaveChanges();
    //    }
    //}
}
