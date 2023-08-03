using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.EntityFrameworkCore.Repositories
{
    public class HISRepository<TEntity, TPrimaryKey> : Core.Repositories.Repository<HISDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        public HISRepository(HISDbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
