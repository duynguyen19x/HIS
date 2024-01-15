using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Domain.EntityFramework
{
    public interface IDbContextProvider<TDbContext> where TDbContext : DbContext
    {
        TDbContext GetDbContext();
        Task<TDbContext> GetDbContextAsync();
    }
}
