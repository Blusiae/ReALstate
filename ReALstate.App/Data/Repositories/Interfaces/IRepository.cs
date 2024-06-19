﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReALstate.App.Data.Repositories.Interfaces
{
    internal interface IRepository<TEntity> where TEntity : class
    {
        Task InitAsync();
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(int id);
        Task CreateAsync(TEntity entity);
        Task DeleteAsync(int id);
    }
}
