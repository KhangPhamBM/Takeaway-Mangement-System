﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackDeliveryLibrary.Repository
{
    internal interface IRepository<T>
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task Add(T entity);

        Task Update(int id, T entity);
        Task Delete(int id);
    }
}
