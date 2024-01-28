using Microsoft.EntityFrameworkCore;

namespace HIS.Core.EntityFrameworkCore
{
    public class EfCoreDbContextProvider<TDbContext> : IDbContextProvider<TDbContext> where TDbContext : DbContext
    {
        public TDbContext DbContext { get; }

        public EfCoreDbContextProvider(TDbContext dbContext)
        {
            DbContext = dbContext;
        }

        TDbContext IDbContextProvider<TDbContext>.GetDbContext()
        {
            return DbContext;
        }

        Task<TDbContext> IDbContextProvider<TDbContext>.GetDbContextAsync()
        {
            return Task.FromResult(DbContext);
        }

        public void Dispose()
        {
            if (DbContext != null)
            {
                DbContext.Dispose();
            }
        }


    }
}
