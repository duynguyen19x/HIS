using HIS.Core.Domain.Repositories;
using HIS.Core.Entities;
using HIS.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Services
{
    public class BaseAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TPagedResultRequest> : BaseAppService, IAsyncCrudAppService<TEntityDto, TPrimaryKey, TPagedResultRequest>
        where TEntity : class, IEntity<TPrimaryKey>
        where TEntityDto : class, IEntityDto<TPrimaryKey>
        where TPagedResultRequest : IPagedResultRequest
    {
        protected readonly IRepository<TEntity, TPrimaryKey> Repository;

        protected BaseAsyncCrudAppService(
            IRepository<TEntity, TPrimaryKey> repository)
        {
            Repository = repository;
        }

        public virtual Task<PagedResultDto<TEntityDto>> GetAllAsync(TPagedResultRequest input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<TEntityDto>> GetAsync(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<TEntityDto>> CreateOrEditAsync(TEntityDto input)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<ResultDto<TEntityDto>> DeleteAsync(TPrimaryKey id)
        {
            var result = new ResultDto<TEntityDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    var entity = Repository.Get(id);
                    await Repository.DeleteAsync(entity);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }
    }
}
