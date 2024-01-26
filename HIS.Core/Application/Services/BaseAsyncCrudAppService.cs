using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Repositories;
using HIS.Core.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace HIS.Core.Application.Services
{
    public abstract class BaseAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TPagedAndSortedResultRequest, TCreateOrEditEntityDto>
        : BaseAppService, IAsyncCrudAppService<TEntityDto, TPrimaryKey, TPagedAndSortedResultRequest, TCreateOrEditEntityDto>
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
            try
            {
                var query = CreateFilteredQuery(input);
                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await query.CountAsync();
                result.Result = paged.Select(MapToEntityDto).ToList();
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<TEntityDto>> GetAsync(TPrimaryKey id)
        {
            var result = new ResultDto<TEntityDto>();
            try
            {
                var entity = await Repository.GetAsync(id);

                result.Result = ObjectMapper.Map<TEntityDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public abstract Task<ResultDto<TEntityDto>> CreateAsync(TCreateOrEditEntityDto input);

        public abstract Task<ResultDto<TEntityDto>> UpdateAsync(TCreateOrEditEntityDto input);

        public abstract Task<ResultDto<TEntityDto>> DeleteAsync(TPrimaryKey id);

        protected virtual IQueryable<TEntity> CreateFilteredQuery(TPagedAndSortedResultRequest input)
        {
            return Repository.GetAll();
        }

        protected virtual TEntityDto MapToEntityDto(TEntity entity)
        {
            return ObjectMapper.Map<TEntityDto>(entity);
        }

        protected virtual TEntity MapToEntity(TCreateOrEditEntityDto entityDto)
        {
            return ObjectMapper.Map<TEntity>(entityDto);
        }
    }
}
