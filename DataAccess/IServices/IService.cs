using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IServices
{
    public interface IService<T>
    {
        IQueryable<T> GetAll();
        T Get(Guid guid);
        T Get(int id);
        void Create(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
