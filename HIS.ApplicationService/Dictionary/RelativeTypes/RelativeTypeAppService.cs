using HIS.Dtos.Dictionaries.RelativeTypes;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Domain.Repositories;
using HIS.Core.Application.Services;
using System.Transactions;

namespace HIS.ApplicationService.Dictionaries.RelativeTypes
{
    public class RelativeTypeAppService : BaseAppService, IRelativeTypeAppService
    {
        private readonly IRepository<RelativeType, Guid> _relativeTypeRepository;

        public RelativeTypeAppService(IRepository<RelativeType, Guid> relativeTypeRepository)
        {
            _relativeTypeRepository = relativeTypeRepository;
        }

        public virtual async Task<ResultDto<RelativeTypeDto>> CreateOrEdit(RelativeTypeDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
            {
                return await Create(input);
            }
            else
            {
                return await Update(input);
            }
        }

        public virtual async Task<ResultDto<RelativeTypeDto>> Create(RelativeTypeDto input)
        {
            var result = new ResultDto<RelativeTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<RelativeType>(input);

                    await _relativeTypeRepository.InsertAsync(entity);

                    await unitOfWork.CompleteAsync();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<RelativeTypeDto>> Update(RelativeTypeDto input)
        {
            var result = new ResultDto<RelativeTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _relativeTypeRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<RelativeTypeDto>> Delete(Guid id)
        {
            var result = new ResultDto<RelativeTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _relativeTypeRepository.Get(id);

                    await _relativeTypeRepository.DeleteAsync(entity);

                    unitOfWork.Complete();
                    result.Success(null);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<PagedResultDto<RelativeTypeDto>> GetAll(GetAllRelativeTypeInputDto input)
        {
            var result = new PagedResultDto<RelativeTypeDto>();
            try
            {
                var filter = _relativeTypeRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(o => o.SortOrder).PageBy(input);
                var data = paged.ToList();

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<RelativeTypeDto>>(data);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<RelativeTypeDto>> GetById(Guid id)
        {
            var result = new ResultDto<RelativeTypeDto>();
            try
            {
                var data = await _relativeTypeRepository.GetAsync(id);
                result.Result = ObjectMapper.Map<RelativeTypeDto>(data);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        
    }
}
