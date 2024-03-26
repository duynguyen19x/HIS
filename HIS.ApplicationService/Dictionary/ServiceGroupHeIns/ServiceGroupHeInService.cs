using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.ApplicationService.Dictionary.ServiceGroupHeIns.Dto;
using HIS.Core.Application.Services;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Transactions;

namespace HIS.ApplicationService.Dictionary.ServiceGroupHeIns
{
    public class ServiceGroupHeInService : BaseAppService, IServiceGroupHeInService
    {
        private readonly IRepository<ServiceGroupHeIn, Guid> _serviceGroupHeInRepository;

        public ServiceGroupHeInService(IRepository<ServiceGroupHeIn, Guid> serviceGroupHeInRepository)
        {
            _serviceGroupHeInRepository = serviceGroupHeInRepository;
        }

        public virtual async Task<ResultDto<ServiceGroupHeInDto>> CreateOrEdit(ServiceGroupHeInDto input)
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

        public virtual async Task<ResultDto<ServiceGroupHeInDto>> Create(ServiceGroupHeInDto input)
        {
            var result = new ResultDto<ServiceGroupHeInDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var entity = ObjectMapper.Map<ServiceGroupHeIn>(input);
                    await _serviceGroupHeInRepository.InsertAsync(entity);

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

        public virtual async Task<ResultDto<ServiceGroupHeInDto>> Update(ServiceGroupHeInDto input)
        {
            var result = new ResultDto<ServiceGroupHeInDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _serviceGroupHeInRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);

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

        public virtual async Task<ResultDto<ServiceGroupHeInDto>> Delete(Guid id)
        {
            var result = new ResultDto<ServiceGroupHeInDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _serviceGroupHeInRepository.Get(id);
                    await _serviceGroupHeInRepository.DeleteAsync(entity);
                    unitOfWork.Complete();
                    result.Success(null);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<PagedResultDto<ServiceGroupHeInDto>> GetAll(GetAllServiceGroupHeInInput input)
        {
            var result = new PagedResultDto<ServiceGroupHeInDto>();

            try
            {
                result.Result = (from r in _serviceGroupHeInRepository.GetAll()
                                 select new ServiceGroupHeInDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Inactive = r.Inactive,
                                     SortOrder = r.SortOrder,
                                 })
                                 .WhereIf(input.InactiveFilter != null, w => w.Inactive == input.InactiveFilter)
                                 .OrderBy(o => o.SortOrder).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<ServiceGroupHeInDto>> GetById(Guid id)
        {
            var result = new ResultDto<ServiceGroupHeInDto>();
            var ItemLine = await _serviceGroupHeInRepository.FirstOrDefaultAsync(id);
            if (ItemLine != null)
            {
                result.Result = ObjectMapper.Map<ServiceGroupHeInDto>(ItemLine);
            }
            return result;
        }
    }
}
