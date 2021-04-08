using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSTICK.Interfaces
{
   public  interface IUnitOfWork
    {
        IGameRepository Games { get; }
        ICategoryRepository Categories { get; }
        void Save();
    }
}
