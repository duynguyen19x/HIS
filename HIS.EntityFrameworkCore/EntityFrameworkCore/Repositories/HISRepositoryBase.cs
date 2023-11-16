using HIS.Core.Entities;
using HIS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Repositories
{
    public class HISRepositoryBase<TEntity, TPrimaryKey> : Repository<HISDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected HISRepositoryBase(HISDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
