using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Repositories;
using HIS.Core.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.EntityFrameworkCore.Repositories
{
    public class HISBulkRepository<TEntity, TPrimaryKey> : BulkRepository<HISDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        public HISBulkRepository(IDbContextProvider<HISDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}
