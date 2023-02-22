using HIS.EntityFrameworkCore.DbContexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HIS.EntityFrameworkCore.BaseEntitys
{
    public interface IRepository<TEntity, TKey>
    {
        #region Implementation

        public TEntity Insert(TEntity entity);

        public void Update(TEntity entity);

        public TEntity Delete(TEntity entity);

        public TEntity Delete(TKey id);

        public bool Deletes(Expression<Func<TEntity, bool>> where);

        public TEntity GetById(TKey id);

        public IQueryable<TEntity> Gets();

        public IQueryable<TEntity> Gets(Expression<Func<TEntity, bool>>? where = null);

        public int Count(Expression<Func<TEntity, bool>> where);

        public IQueryable<TEntity> Gets(string[]? includes = null);

        public TEntity GetByCondition(Expression<Func<TEntity, bool>> expression, string[]? includes = null);

        public IEnumerable<TEntity> Gets(Expression<Func<TEntity, bool>> predicate, string[]? includes = null);

        public IEnumerable<TEntity> GetsPaging(Expression<Func<TEntity, bool>> predicate, out int total, int index = 0, int size = 20, string[]? includes = null);

        public bool CheckContains(Expression<Func<TEntity, bool>> predicate);

        public Task<TEntity> InsertAsync(TEntity entity);

        public Task<TEntity> UpdateAsync(TEntity entity);

        public Task<TEntity> DeleteAsync(TEntity entity);

        public Task<TEntity> DeleteAsync(TKey id);

        public Task<bool> DeletesAsync(Expression<Func<TEntity, bool>> where);

        public Task<TEntity> GetByIdAsync(TKey id);

        public Task<IQueryable<TEntity>> GetsAsync();

        public Task<IQueryable<TEntity>> GetsAsync(Expression<Func<TEntity, bool>>? where = null);

        public Task<int> CountAsync(Expression<Func<TEntity, bool>> where);

        public Task<IQueryable<TEntity>> GetsAsync(string[]? includes = null);

        public Task<TEntity> GetByConditionAsync(Expression<Func<TEntity, bool>> expression, string[]? includes = null);

        public Task<IEnumerable<TEntity>> GetsAsync(Expression<Func<TEntity, bool>> predicate, string[]? includes = null);

        public Task<bool> CheckContainsAsync(Expression<Func<TEntity, bool>> predicate);

        #endregion
    }

    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        private HIS_DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(HIS_DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        #region Implementation

        public TEntity Insert(TEntity entity)
        {
            return _dbSet.Add(entity).Entity;
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public TEntity Delete(TEntity entity)
        {
            return _dbSet.Remove(entity).Entity;
        }

        public TEntity Delete(TKey id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
                return _dbSet.Remove(entity).Entity;
            else

#pragma warning disable CS8603 // Possible null reference return.
                return entity;
#pragma warning restore CS8603 // Possible null reference return.
        }

        public bool Deletes(Expression<Func<TEntity, bool>> where)
        {
            IEnumerable<TEntity> objects = _dbSet.Where(where).AsEnumerable();
            _dbSet.RemoveRange(objects);

            return objects.Any();
        }

        public TEntity GetById(TKey id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return _dbSet.Find(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public IQueryable<TEntity> Gets()
        {
            return _dbSet;
        }

        public IQueryable<TEntity> Gets(Expression<Func<TEntity, bool>>? where = null)
        {
            if (where == null)
                return _dbSet;

            return _dbSet.Where(where);
        }

        public int Count(Expression<Func<TEntity, bool>> where)
        {
            return _dbSet.Count(where);
        }

        public IQueryable<TEntity> Gets(string[]? includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = _dbContext.Set<TEntity>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.AsQueryable();
            }

            return _dbContext.Set<TEntity>().AsQueryable();
        }

        public TEntity GetByCondition(Expression<Func<TEntity, bool>> expression, string[]? includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = _dbContext.Set<TEntity>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
#pragma warning disable CS8603 // Possible null reference return.
                return query.FirstOrDefault(expression);
#pragma warning restore CS8603 // Possible null reference return.
            }
#pragma warning disable CS8603 // Possible null reference return.
            return _dbContext.Set<TEntity>().FirstOrDefault(expression);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public IEnumerable<TEntity> Gets(Expression<Func<TEntity, bool>> predicate, string[]? includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = _dbContext.Set<TEntity>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.Where(predicate).AsQueryable();
            }

            return _dbContext.Set<TEntity>().Where<TEntity>(predicate).AsQueryable<TEntity>();
        }

        public IEnumerable<TEntity> GetsPaging(Expression<Func<TEntity, bool>> predicate, out int total, int index = 0, int size = 20, string[]? includes = null)
        {
            int skipCount = index * size;
            IQueryable<TEntity> _resetSet;

            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = _dbContext.Set<TEntity>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                _resetSet = predicate != null ? query.Where<TEntity>(predicate).AsQueryable() : query.AsQueryable();
            }
            else
                _resetSet = predicate != null ? _dbContext.Set<TEntity>().Where<TEntity>(predicate).AsQueryable() : _dbContext.Set<TEntity>().AsQueryable();

            _resetSet = skipCount == 0 ? _resetSet.Take(size) : _resetSet.Skip(skipCount).Take(size);
            total = _resetSet.Count();

            return _resetSet.AsQueryable();
        }

        public bool CheckContains(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Count<TEntity>(predicate) > 0;
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            return await Task.FromResult(_dbSet.Add(entity).Entity);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var entityEntry = _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;

            return await Task.FromResult(entityEntry.Entity);
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            return await Task.FromResult(_dbSet.Remove(entity).Entity);
        }

        public async Task<TEntity> DeleteAsync(TKey id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
                await Task.FromResult(_dbSet.Remove(entity));

#pragma warning disable CS8603 // Possible null reference return.
            return await Task.FromResult(entity);
        }

        public async Task<bool> DeletesAsync(Expression<Func<TEntity, bool>> where)
        {
            IEnumerable<TEntity> objects = _dbSet.Where(where).AsEnumerable();
            _dbSet.RemoveRange(objects);

            return await Task.FromResult(objects.Any());
        }

        public async Task<TEntity> GetByIdAsync(TKey id)
        {
            return await Task.FromResult(_dbSet.Find(id));
        }

        public async Task<IQueryable<TEntity>> GetsAsync()
        {
            return await Task.FromResult(_dbSet);
        }

        public async Task<IQueryable<TEntity>> GetsAsync(Expression<Func<TEntity, bool>>? where = null)
        {
            if (where == null)
                return await Task.FromResult(_dbSet);

            return await Task.FromResult(_dbSet.Where(where));
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> where)
        {
            return await Task.FromResult(_dbSet.Count(where));
        }

        public async Task<IQueryable<TEntity>> GetsAsync(string[]? includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = _dbContext.Set<TEntity>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);

                return await Task.FromResult(query.AsQueryable());
            }

            return await Task.FromResult(_dbContext.Set<TEntity>().AsQueryable());
        }

        public async Task<TEntity> GetByConditionAsync(Expression<Func<TEntity, bool>> expression, string[]? includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = _dbContext.Set<TEntity>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);

                return await Task.FromResult(query.FirstOrDefault(expression));
            }
            return await Task.FromResult(_dbContext.Set<TEntity>().FirstOrDefault(expression));
        }

        public async Task<IEnumerable<TEntity>> GetsAsync(Expression<Func<TEntity, bool>> predicate, string[]? includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = _dbContext.Set<TEntity>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);

                return await Task.FromResult(query.Where(predicate).AsQueryable());
            }

            return await Task.FromResult(_dbSet.Where(predicate).AsQueryable());
        }

        public async Task<bool> CheckContainsAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Task.FromResult(_dbSet.Count(predicate) > 0);
        }

        #endregion
    }
}
