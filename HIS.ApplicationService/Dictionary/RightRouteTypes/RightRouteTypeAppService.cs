using HIS.Dtos.Dictionaries.RightRouteTypes;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Domain.Repositories;
using HIS.Core.Application.Services;
using System.Transactions;

namespace HIS.ApplicationService.Dictionaries.RightRouteTypes
{
    public class RightRouteTypeAppService : BaseAppService, IRightRouteTypeAppService
    {
        private readonly IRepository<RightRouteType, int> _rightRouteTypeRepository;

        public RightRouteTypeAppService(IRepository<RightRouteType, int> rightRouteTypeRepository)
        {
            _rightRouteTypeRepository = rightRouteTypeRepository;
        }

        public virtual async Task<ResultDto<RightRouteTypeDto>> CreateOrEdit(RightRouteTypeDto input)
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

        public virtual async Task<ResultDto<RightRouteTypeDto>> Create(RightRouteTypeDto input)
        {
            var result = new ResultDto<RightRouteTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = _rightRouteTypeRepository.GetAll().DefaultIfEmpty().Max(x => x.Id) + 1;
                    var entity = ObjectMapper.Map<RightRouteType>(input);

                    await _rightRouteTypeRepository.InsertAsync(entity);

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

        public virtual async Task<ResultDto<RightRouteTypeDto>> Update(RightRouteTypeDto input)
        {
            var result = new ResultDto<RightRouteTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _rightRouteTypeRepository.GetAsync(input.Id);

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

        public virtual async Task<ResultDto<RightRouteTypeDto>> Delete(int id)
        {
            var result = new ResultDto<RightRouteTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _rightRouteTypeRepository.Get(id);

                    await _rightRouteTypeRepository.DeleteAsync(entity);

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

        public virtual async Task<PagedResultDto<RightRouteTypeDto>> GetAll(GetAllRightRouteTypeInputDto input)
        {
            var result = new PagedResultDto<RightRouteTypeDto>();
            try
            {
                var filter = _rightRouteTypeRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.RightRouteTypeCodeFilter), x => x.RightRouteTypeCode == input.RightRouteTypeCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.RightRouteTypeNameFilter), x => x.RightRouteTypeName == input.RightRouteTypeNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(o => o.SortOrder).PageBy(input).ToList();

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<RightRouteTypeDto>>(paged);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<RightRouteTypeDto>> GetById(int id)
        {
            var result = new ResultDto<RightRouteTypeDto>();
            try
            {
                result.Result = ObjectMapper.Map<RightRouteTypeDto>(await _rightRouteTypeRepository.GetAsync(id));
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        
    }
}
