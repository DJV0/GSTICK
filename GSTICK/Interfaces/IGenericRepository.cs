using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSTICK.Interfaces
{
    public interface IGenericRepository<T> where T: class 
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Add(T entity);
    }
}
