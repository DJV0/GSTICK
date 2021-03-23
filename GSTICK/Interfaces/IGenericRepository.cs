﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSTICK.Interfaces
{
    interface IGenericRepository<T> where T: class 
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
