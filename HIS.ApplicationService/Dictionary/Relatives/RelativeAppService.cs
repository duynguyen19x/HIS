using Microsoft.EntityFrameworkCore;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Domain.Repositories;
using HIS.Core.Application.Services;
using System.Transactions;
using HIS.ApplicationService.Dictionary.RelativeTypes;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using HIS.ApplicationService.Dictionary.RelativeTypes.Dto;

namespace HIS.ApplicationService.Dictionaries.RelativeTypes
{
    public class RelativeAppService : BaseAppService, IRelativeAppService
    {
        private readonly IRepository<Relative, Guid> _relativeTypeRepository;

        public RelativeAppService(IRepository<Relative, Guid> relativeTypeRepository)
        {
            _relativeTypeRepository = relativeTypeRepository;
        }

        public virtual async Task<ResultDto<RelativeDto>> CreateOrEdit(RelativeDto input)
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

        public virtual async Task<ResultDto<RelativeDto>> Create(RelativeDto input)
        {
            var result = new ResultDto<RelativeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<Relative>(input);

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

        public virtual async Task<ResultDto<RelativeDto>> Update(RelativeDto input)
        {
            var result = new ResultDto<RelativeDto>();
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

        public virtual async Task<ResultDto<RelativeDto>> Delete(Guid id)
        {
            var result = new ResultDto<RelativeDto>();
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

        public virtual async Task<PagedResultDto<RelativeDto>> GetAll(GetAllRelativeInputDto input)
        {
            var result = new PagedResultDto<RelativeDto>();
            try
            {
                var filter = _relativeTypeRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                if (Check.IsNullOrDefault(input.Sorting))
                    input.Sorting = "SortOrder";

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<RelativeDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<RelativeDto>> GetById(Guid id)
        {
            var result = new ResultDto<RelativeDto>();
            try
            {
                var data = await _relativeTypeRepository.GetAsync(id);
                result.Result = ObjectMapper.Map<RelativeDto>(data);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        
    }
}
