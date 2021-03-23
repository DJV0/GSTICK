using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSTICK.Interfaces
{
    public interface IGenericRepository<T> where T: class 
    {
        Task<List<T>> GetAllAsync();
        T GetById(int id);
    }
}
