﻿using HIS.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Repositories
{
    public abstract class Repository<TDbContext, TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
        where TDbContext : DbContext 
        where TEntity : class, IEntity<TPrimaryKey>
    {
        private readonly TDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        //
        // Summary:
        //     Constructor
        //
        // Parameters:
        //   dbContextProvider:
        public Repository(TDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return GetTable().AsQueryable();
        }
        public virtual List<TEntity> GetAllList()
        {
            return _dbSet.ToList();
        }
        public virtual List<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }
        public virtual async Task<List<TEntity>> GetAllListAsync()
        {
            return await _dbSet.ToListAsync().ConfigureAwait(continueOnCapturedContext: false);
        }
        public virtual async Task<List<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync().ConfigureAwait(continueOnCapturedContext: false);
        }


        public virtual TEntity Get(TPrimaryKey id)
        {
            return FirstOrDefault(id) ?? throw new Exception($"There is no such an entity. Entity type: {typeof(TEntity).FullName}, id: {id}");
        }
        public virtual async Task<TEntity> GetAsync(TPrimaryKey id)
        {
            return (await FirstOrDefaultAsync(id).ConfigureAwait(continueOnCapturedContext: false)) ?? throw new Exception($"There is no such an entity. Entity type: {typeof(TEntity).FullName}, id: {id}");
        }
        public virtual TEntity FirstOrDefault(TPrimaryKey id)
        {
            return GetAll().FirstOrDefault(CreateEqualityExpressionForId(id));
        }
        public virtual async Task<TEntity> FirstOrDefaultAsync(TPrimaryKey id)
        {
            return await GetAll().FirstOrDefaultAsync(CreateEqualityExpressionForId(id)).ConfigureAwait(false);
        }
        public virtual async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await GetAll().FirstOrDefaultAsync(predicate).ConfigureAwait(false);
        }


        public virtual TEntity Insert(TEntity entity)
        {
            return _dbSet.Add(entity).Entity;
        }
        public virtual async Task<TEntity> InsertAsync(TEntity entity)
        {
            return await Task.FromResult(Insert(entity));
        }


        public virtual TEntity Update(TEntity entity)
        {
            AttachIfNot(entity);
            GetContext().Entry(entity).State = EntityState.Modified;
            return entity;
        }
        public virtual TEntity Update(TPrimaryKey id, Action<TEntity> updateAction)
        {
            TEntity val = Get(id);
            updateAction(val);
            return val;
        }
        public virtual Task<TEntity> UpdateAsync(TEntity entity)
        {
            entity = Update(entity);
            return Task.FromResult(entity);
        }
        public virtual async Task<TEntity> UpdateAsync(TPrimaryKey id, Func<TEntity, Task> updateAction)
        {
            TEntity entity = await GetAsync(id).ConfigureAwait(continueOnCapturedContext: false);
            await updateAction(entity).ConfigureAwait(continueOnCapturedContext: false);
            return entity;
        }


        public virtual void Delete(TEntity entity)
        {
            AttachIfNot(entity);
            GetTable().Remove(entity);
        }
        public virtual void Delete(TPrimaryKey id)
        {
            TEntity fromChangeTrackerOrNull = GetFromChangeTrackerOrNull(id);
            if (fromChangeTrackerOrNull != null)
            {
                Delete(fromChangeTrackerOrNull);
                return;
            }

            fromChangeTrackerOrNull = FirstOrDefault(id);
            if (fromChangeTrackerOrNull != null)
            {
                Delete(fromChangeTrackerOrNull);
            }
        }
        public virtual void Delete(Expression<Func<TEntity, bool>> predicate)
        {
            foreach (TEntity all in GetAllList(predicate))
            {
                Delete(all);
            }
        }
        public virtual Task DeleteAsync(TEntity entity)
        {
            Delete(entity);
            return Task.CompletedTask;
        }
        public virtual Task DeleteAsync(TPrimaryKey id)
        {
            Delete(id);
            return Task.CompletedTask;
        }
        public virtual async Task DeleteAsync(Expression<Func<TEntity, bool>> predicate)
        {
            foreach (TEntity item in await GetAllListAsync(predicate).ConfigureAwait(continueOnCapturedContext: false))
            {
                await DeleteAsync(item).ConfigureAwait(continueOnCapturedContext: false);
            }
        }

        
        public virtual TDbContext GetContext()
        {
            return _dbContext;
        }
        public virtual DbSet<TEntity> GetTable()
        {
            return GetContext().Set<TEntity>();
        }
        protected virtual void AttachIfNot(TEntity entity)
        {
            if (_dbContext.ChangeTracker.Entries().FirstOrDefault((EntityEntry ent) => ent.Entity == entity) == null)
            {
                _dbSet.Attach(entity);
            }
        }
        protected virtual Expression<Func<TEntity, bool>> CreateEqualityExpressionForId(TPrimaryKey id)
        {
            ParameterExpression parameterExpression = Expression.Parameter(typeof(TEntity));
            MemberExpression memberExpression = Expression.PropertyOrField(parameterExpression, "Id");
            object idValue = Convert.ChangeType(id, typeof(TPrimaryKey));
            UnaryExpression right = Expression.Convert(((Expression<Func<object>>)(() => idValue)).Body, memberExpression.Type);
            return Expression.Lambda<Func<TEntity, bool>>(Expression.Equal(memberExpression, right), new ParameterExpression[1] { parameterExpression });
        }
        private TEntity GetFromChangeTrackerOrNull(TPrimaryKey id)
        {
            return GetContext().ChangeTracker.Entries().FirstOrDefault((EntityEntry ent) => ent.Entity is TEntity && EqualityComparer<TPrimaryKey>.Default.Equals(id, (ent.Entity as TEntity).Id))?.Entity as TEntity;
        }
    }
}