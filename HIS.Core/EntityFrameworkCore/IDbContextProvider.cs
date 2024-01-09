using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.EntityFrameworkCore
{
    public interface IDbContextProvider<TDbContext> where TDbContext : DbContext
    {
        Task<TDbContext> GetDbContextAsync();
        TDbContext GetDbContext();
    }
}
