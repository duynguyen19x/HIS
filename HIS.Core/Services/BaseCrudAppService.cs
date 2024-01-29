using HIS.Core.Domain.Repositories;
using HIS.Core.Domain.Uow;
using HIS.Core.Services.Dto;
using HIS.Core.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using HIS.Core.Domain.Entities;

namespace HIS.Core.Services
{
    public abstract class BaseCrudAppService2<TEntity, TEntityDto, TPrimaryKey, TPagedAndSortedResultRequest> 
        : BaseAppService, ICrudAppService<TEntityDto, TPrimaryKey, TPagedAndSortedResultRequest>
        where TEntity : class, IEntity<TPrimaryKey>
        where TEntityDto : class, IEntityDto<TPrimaryKey>
        where TPagedAndSortedResultRequest : IPagedAndSortedResultRequest
    {
        protected readonly IRepository<TEntity, TPrimaryKey> Repository;

        protected BaseCrudAppService2(
            IRepository<TEntity, TPrimaryKey> repository)
        {
            Repository = repository;
        }

        public virtual PagedResultDto<TEntityDto> GetAll(TPagedAndSortedResultRequest input)
        {
            var result = new PagedResultDto<TEntityDto>();
            var query = CreateFilteredQuery(input);

            var totalCount = query.Count();
            var paged = query.ApplySortingAndPaging(input);

            return result;
        }

        public virtual ResultDto<TEntityDto> Get(TPrimaryKey id)
        {
            var result = new ResultDto<TEntityDto>();
            try
            {
                var entity = Repository.Get(id);
                result.Result = ObjectMapper.Map<TEntityDto>(entity);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual ResultDto<TEntityDto> CreateOrEdit(TEntityDto input)
        {
            TPrimaryKey key = default(TPrimaryKey);
            if (Equals(input.Id, key))
                return Create(input);
            else
                return Update(input);
            
        }

        public virtual ResultDto<TEntityDto> Create(TEntityDto input)
        {
            throw new NotImplementedException();
        }

        public virtual ResultDto<TEntityDto> Update(TEntityDto input)
        {
            throw new NotImplementedException();
        }

        public virtual ResultDto<TEntityDto> Delete(TPrimaryKey id)
        {
            var result = new ResultDto<TEntityDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    var entity = Repository.Get(id);
                    Repository.Delete(entity);
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
