using AutoMapper;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace HIS.Application.Core.Services
{
    public abstract class BaseAppService : IBaseAppService
    {
        public virtual HISDbContext Context { get; set; }
        public virtual IMapper ObjectMapper { get; set; }

        public BaseAppService(HISDbContext context, IMapper mapper) 
        {
            Context = context;
            ObjectMapper = mapper;
        }

        public virtual TResult BeginTransaction<TResult>(Action<TResult> func) 
        {
            var result = Activator.CreateInstance<TResult>();
            if (Context.Database.CurrentTransaction != null)
            {
                func(result);
            }
            else
            {
                using (var transaction = Context.Database.BeginTransaction())
                {
                    try
                    {
                        func(result);
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }

            }
            return result;
        }

        public virtual async Task<TResult> BeginTransactionAsync<TResult>(Func<TResult, Task> func) where TResult : class
        {
            var result = Activator.CreateInstance<TResult>();
            if (Context.Database.CurrentTransaction != null)
            {
                await func(result);
            }
            else
            {
                using (var transaction = await Context.Database.BeginTransactionAsync())
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

        public virtual void SaveChanges() 
        {
            Context.SaveChanges();
        }

        public virtual async Task SaveChangesAsync() 
        {
            await Context.SaveChangesAsync();
        }

    }
}
