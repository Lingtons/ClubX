using DataAccess.IServices;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class MessagesService : IService<Message>
    {
        readonly ClubxContext _context = new();

        public void Create(Message obj)
        {
            obj.CreatedAt = DateTime.Now;
            _context.Messages.Add(obj);
            _context.SaveChanges();
        }

        public IQueryable<Message> GetAll()
        {
            return _context.Messages;
        }

        public Message Get(int id)
        {
            return _context.Messages.FirstOrDefault(e => e.Id == id);
        }

        public Message Get(Guid guid)
        {
            throw new NotImplementedException();
        }


        public void Delete(Message obj)
        {
            var el = _context.Messages.FirstOrDefault(e => e.Id == obj.Id);
            _context.Messages.Remove(el);
            _context.SaveChanges();

        }

        public void Update(Message obj)
        {
            var old = _context.Messages.FirstOrDefault(e => e.Id == obj.Id);
            _context.Entry(old).CurrentValues.SetValues(obj);
            _context.SaveChanges();
        }
    }
}
