using HIS.Core.Domain.Entities;
using HIS.Core.Domain.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace HIS.Core.Domain.Repositories
{
    public abstract class Repository<TDbContext, TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
        where TDbContext : DbContext
        where TEntity : class, IEntity<TPrimaryKey>
    {
        private readonly TDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(IDbContextProvider<TDbContext> dbContextProvider)
        {
            _dbContext = dbContextProvider.GetDbContext();
            _dbSet = _dbContext.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> GetAll() => _dbSet.AsQueryable();

        public virtual List<TEntity> GetAllList() => _dbSet.ToList();
        public virtual async Task<List<TEntity>> GetAllListAsync() => await _dbSet.ToListAsync().ConfigureAwait(continueOnCapturedContext: false);
        public virtual List<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate) => _dbSet.Where(predicate).ToList();
        public virtual async Task<List<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate) => await _dbSet.Where(predicate).ToListAsync().ConfigureAwait(continueOnCapturedContext: false);

        public virtual TEntity Get(TPrimaryKey id) => FirstOrDefault(id) ?? throw new Exception($"There is no such an entity. Entity type: {typeof(TEntity).FullName}, id: {id}");
        public virtual async Task<TEntity> GetAsync(TPrimaryKey id) => await FirstOrDefaultAsync(id) ?? throw new Exception($"There is no such an entity. Entity type: {typeof(TEntity).FullName}, id: {id}");

        public virtual TEntity Insert(TEntity entity) => _dbSet.Add(entity).Entity;
        public virtual TPrimaryKey InsertAndGetId(TEntity entity)
        {
            return Insert(entity).Id;
        }
        public virtual async Task<TEntity> InsertAsync(TEntity entity) => await Task.FromResult(Insert(entity));
        public virtual async Task<TPrimaryKey> InsertAndGetIdAsync(TEntity entity)
        {
            var insertedEntity = await InsertAsync(entity);
            return insertedEntity.Id;
        }

        public virtual TEntity Update(TEntity entity)
        {
            AttachIfNot(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }
        public virtual async Task<TEntity> UpdateAsync(TEntity entity) => await Task.FromResult(Update(entity));
        public virtual TEntity Update(TPrimaryKey id, Action<TEntity> updateAction)
        {
            TEntity entity = Get(id);
            updateAction(entity);
            return entity;
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
            _dbSet.Remove(entity);
        }
        public virtual Task DeleteAsync(TEntity entity)
        {
            Delete(entity);
            return Task.CompletedTask;
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
        public virtual Task DeleteAsync(TPrimaryKey id)
        {
            Delete(id);
            return Task.CompletedTask;
        }
        public virtual void Delete(Expression<Func<TEntity, bool>> predicate)
        {
            foreach (TEntity all in GetAllList(predicate))
            {
                Delete(all);
            }
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

        public virtual TEntity FirstOrDefault(TPrimaryKey id)
        {
            return GetAll().FirstOrDefault(CreateEqualityExpressionForId(id));
        }
        public virtual async Task<TEntity> FirstOrDefaultAsync(TPrimaryKey id)
        {
            return await GetAll().FirstOrDefaultAsync(CreateEqualityExpressionForId(id)).ConfigureAwait(false);
        }
        protected virtual Expression<Func<TEntity, bool>> CreateEqualityExpressionForId(TPrimaryKey id)
        {
            ParameterExpression parameterExpression = Expression.Parameter(typeof(TEntity));
            MemberExpression memberExpression = Expression.PropertyOrField(parameterExpression, "Id");
            object idValue = Convert.ChangeType(id, typeof(TPrimaryKey));
            UnaryExpression right = Expression.Convert(((Expression<Func<object>>)(() => idValue)).Body, memberExpression.Type);
            return Expression.Lambda<Func<TEntity, bool>>(Expression.Equal(memberExpression, right), new ParameterExpression[1] { parameterExpression });
        }
        protected virtual void AttachIfNot(TEntity entity)
        {
            if (_dbContext.ChangeTracker.Entries().FirstOrDefault((ent) => ent.Entity == entity) == null)
            {
                _dbSet.Attach(entity);
            }
        }
        protected virtual TEntity GetFromChangeTrackerOrNull(TPrimaryKey id)
        {
            return _dbContext.ChangeTracker.Entries().FirstOrDefault((ent) => ent.Entity is TEntity && EqualityComparer<TPrimaryKey>.Default.Equals(id, (ent.Entity as TEntity).Id))?.Entity as TEntity;
        }
    }
}
