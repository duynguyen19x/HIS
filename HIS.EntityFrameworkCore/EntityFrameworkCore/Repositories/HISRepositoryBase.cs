using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.Repositories
{
    public abstract class HISRepositoryBase<TEntity, TPrimaryKey> : HISRepository<HISDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected HISRepositoryBase(HISDbContext dbContext)
            : base(dbContext)
        {
        }
    }

    public abstract class HISRepositoryBase<TEntity> : HISRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected HISRepositoryBase(HISDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
