using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericWithIdentityModel.Data.Patterns.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IList<T>> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
