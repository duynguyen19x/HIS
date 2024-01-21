using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Repositories;
using HIS.Core.Linq.Extensions;
using HIS.Core.Services.Dto;
using Microsoft.EntityFrameworkCore;

namespace HIS.Core.Services
{
    public class BaseAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TPagedAndSortedResultRequest> : BaseAppService, IAsyncCrudAppService<TEntityDto, TPrimaryKey, TPagedAndSortedResultRequest>
        where TEntity : class, IEntity<TPrimaryKey>
        where TEntityDto : class, IEntityDto<TPrimaryKey>
        where TPagedAndSortedResultRequest : IPagedAndSortedResultRequest
    {
        protected readonly IRepository<TEntity, TPrimaryKey> Repository;

        protected BaseAsyncCrudAppService(
            IRepository<TEntity, TPrimaryKey> repository)
        {
            Repository = repository;
        }

        public virtual async Task<PagedResultDto<TEntityDto>> GetAllAsync(TPagedAndSortedResultRequest input)
        {
            var result = new PagedResultDto<TEntityDto>();
            var query = CreateFilteredQuery(input);
            var paged = query.ApplySortingAndPaging(input);

            result.TotalCount = await query.CountAsync();
            result.Result = ObjectMapper.Map<IList<TEntityDto>>(paged.ToList());
            return result;
        }

        public virtual Task<ResultDto<TEntityDto>> GetAsync(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<ResultDto<TEntityDto>> CreateOrEditAsync(TEntityDto input)
        {
            TPrimaryKey key = default(TPrimaryKey);
            if (Equals(input.Id, key))
                return await CreateAsync(input);
            else
                return await UpdateAsync(input);
        }

        public virtual Task<ResultDto<TEntityDto>> CreateAsync(TEntityDto input)
        {
            throw new NullReferenceException();
        }

        public virtual Task<ResultDto<TEntityDto>> UpdateAsync(TEntityDto input)
        {
            throw new NullReferenceException();
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

        protected virtual IQueryable<TEntity> CreateFilteredQuery(TPagedAndSortedResultRequest input)
        {
            return Repository.GetAll();
        }
    }
}
