using Microsoft.EntityFrameworkCore;
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
    }
}
