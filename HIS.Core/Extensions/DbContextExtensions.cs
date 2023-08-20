using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Extensions
{
    public static class DbContextExtensions
    {
        public static async Task TransactionAsync(this DbContext context, Func<Task> action)
        {
            if (context.Database.CurrentTransaction != null)
            {
                await action();
            }
            else
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        await action();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public static async Task<TResult> UsingTransactionAsync<TResult>(this DbContext dbContext, Func<TResult, Task> func)
            where TResult : class
        {
            var result = Activator.CreateInstance<TResult>();
            if (dbContext.Database.CurrentTransaction != null)
            {
                await func(result);
            }
            else
            {
                using (var transaction = await dbContext.Database.BeginTransactionAsync())
                {
                    try
                    {
                        await func(result);
                        await transaction.CommitAsync();
                    }
                    catch
                    {
                        await transaction.RollbackAsync();
                        throw;
                    }
                }
                
            }
            return result;
        }
    }
}
