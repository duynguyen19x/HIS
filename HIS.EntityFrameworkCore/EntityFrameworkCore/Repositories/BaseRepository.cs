using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.EntityFrameworkCore.Repositories
{
    public class BaseRepository<TEntity, TPrimaryKey> : HIS.Core.Repositories.Repository<HISDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        public BaseRepository(HISDbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
