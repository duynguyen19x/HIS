﻿using HIS.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Repositories
{
    public interface IRepository<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
        IQueryable<TEntity> GetAll();

        List<TEntity> GetAllList();
        Task<List<TEntity>> GetAllListAsync();
        List<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate);

        TEntity Get(TPrimaryKey id);
        Task<TEntity> GetAsync(TPrimaryKey id);

        TEntity Insert(TEntity entity);
        Task<TEntity> InsertAsync(TEntity entity);

        TEntity Update(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        TEntity Update(TPrimaryKey id, Action<TEntity> updateAction);
        Task<TEntity> UpdateAsync(TPrimaryKey id, Func<TEntity, Task> updateAction);

        void Delete(TEntity entity);
        Task DeleteAsync(TEntity entity);
        void Delete(TPrimaryKey id);
        Task DeleteAsync(TPrimaryKey id);
        void Delete(Expression<Func<TEntity, bool>> predicate);
        Task DeleteAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
