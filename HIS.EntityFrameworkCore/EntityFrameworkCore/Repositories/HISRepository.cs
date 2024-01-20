using HIS.Core.Domain.Entities;
using HIS.Core.Domain.EntityFramework;
using HIS.Core.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace HIS.EntityFrameworkCore.Repositories
{
    public class HISRepository<TEntity, TPrimaryKey> : Repository<HISDbContext, TEntity, TPrimaryKey>, IRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        public HISRepository(IDbContextProvider<HISDbContext> dbContextProvider) 
            : base(dbContextProvider)
        {
            
        }
    }
}
