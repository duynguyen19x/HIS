using HIS.Core.Domain.Repositories;
using HIS.Core.Domain.Uow;
using HIS.Core.Entities;
using HIS.Core.Services.Dto;
using HIS.Core.Linq.Extensions;
using Microsoft.EntityFrameworkCore;

namespace HIS.Core.Services
{
    public class BaseCrudAppService2<TEntity, TEntityDto, TPrimaryKey, TPagedResultRequest> : BaseAppService, ICrudAppService<TEntityDto, TPrimaryKey, TPagedResultRequest>
        where TEntity : class, IEntity<TPrimaryKey>
        where TEntityDto : class, IEntityDto<TPrimaryKey>
        where TPagedResultRequest : IPagedResultRequest
    {
        protected readonly IRepository<TEntity, TPrimaryKey> Repository;

        protected BaseCrudAppService2(
            IRepository<TEntity, TPrimaryKey> repository)
        {
            Repository = repository;
        }

        public virtual async Task<PagedResultDto<TEntityDto>> GetAll(TPagedResultRequest input)
        {
            var result = new PagedResultDto<TEntityDto>();
            var query = CreateFilteredQuery(input);

            var totalCount = await query.CountAsync();
            var paged = query.OrderBy(input).PageBy(input);

            return result;
        }

        public virtual async Task<ResultDto<TEntityDto>> Get(TPrimaryKey id)
        {
            var result = new ResultDto<TEntityDto>();
            try
            {
                var entity = await Repository.GetAsync(id);
                result.Result = ObjectMapper.Map<TEntityDto>(entity);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<TEntityDto>> CreateOrEdit(TEntityDto input)
        {
            TPrimaryKey key = default(TPrimaryKey);
            if (Equals(input.Id, key))
                return await Create(input);
            else
                return await Update(input);
            
        }

        public virtual Task<ResultDto<TEntityDto>> Create(TEntityDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<TEntityDto>> Update(TEntityDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<TEntityDto>> Delete(TPrimaryKey id)
        {
            throw new NotImplementedException();
        }


        protected virtual IQueryable<TEntity> CreateFilteredQuery(TPagedResultRequest input)
        {
            return Repository.GetAll();
        }
    }
}
