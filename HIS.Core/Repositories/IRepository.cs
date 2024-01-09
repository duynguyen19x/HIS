using HIS.Core.Entities;
using System.Linq.Expressions;

namespace HIS.Core.Repositories
{
    public interface IRepository<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
        public IQueryable<TEntity> GetAll();

        public List<TEntity> GetAllList();
        public Task<List<TEntity>> GetAllListAsync();
        public List<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate);
        public Task<List<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate);

        public TEntity Get(TPrimaryKey id);
        public Task<TEntity> GetAsync(TPrimaryKey id);

        public TEntity Insert(TEntity entity);
        public Task<TEntity> InsertAsync(TEntity entity);

        public TEntity Update(TEntity entity);
        public Task<TEntity> UpdateAsync(TEntity entity);
        public TEntity Update(TPrimaryKey id, Action<TEntity> updateAction);
        public Task<TEntity> UpdateAsync(TPrimaryKey id, Func<TEntity, Task> updateAction);

        public void Delete(TEntity entity);
        public Task DeleteAsync(TEntity entity);
        public void Delete(TPrimaryKey id);
        public Task DeleteAsync(TPrimaryKey id);
        public void Delete(Expression<Func<TEntity, bool>> predicate);
        public Task DeleteAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
