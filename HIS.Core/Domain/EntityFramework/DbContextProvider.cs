﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Domain.EntityFramework
{
    public class DbContextProvider<TDbContext> : IDbContextProvider<TDbContext> where TDbContext : DbContext
    {
        public TDbContext DbContext { get; }

        public DbContextProvider(TDbContext dbContext)
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
