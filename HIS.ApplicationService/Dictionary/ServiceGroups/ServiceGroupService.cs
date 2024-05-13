using AutoMapper;
using Microsoft.Extensions.Configuration;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Domain.Repositories;
using HIS.ApplicationService.Dictionary.ServiceGroups.Dto;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.Core.Application.Services;
using HIS.Dtos.Dictionaries.Province;
using System.Transactions;
using HIS.EntityFrameworkCore.Entities;

namespace HIS.ApplicationService.Dictionary.ServiceGroups
{
    public class ServiceGroupService : BaseAppService, IServiceGroupService
    {
        private readonly IRepository<ServiceGroup, Guid> _serviceGroupRepository;

        public ServiceGroupService(IRepository<ServiceGroup, Guid> serviceGroupRepository)
        {
            _serviceGroupRepository = serviceGroupRepository;
        }

        public virtual async Task<ResultDto<ServiceGroupDto>> CreateOrEdit(ServiceGroupDto input)
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

        public virtual async Task<ResultDto<ServiceGroupDto>> Create(ServiceGroupDto input)
        {
            var result = new ResultDto<ServiceGroupDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<ServiceGroup>(input);

                    await _serviceGroupRepository.InsertAsync(entity);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<ServiceGroupDto>> Update(ServiceGroupDto input)
        {
            var result = new ResultDto<ServiceGroupDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _serviceGroupRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<ServiceGroupDto>> Delete(Guid id)
        {
            var result = new ResultDto<ServiceGroupDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _serviceGroupRepository.Get(id);

                    await _serviceGroupRepository.DeleteAsync(entity);

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

        public virtual async Task<PagedResultDto<ServiceGroupDto>> GetAll(GetAllServiceGroupInput input)
        {
            var result = new PagedResultDto<ServiceGroupDto>();

            try
            {
                result.Result = (from r in _serviceGroupRepository.GetAll()
                                 select new ServiceGroupDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Inactive = r.Inactive,
                                     SortOrder = r.SortOrder,
                                 })
                                 .WhereIf(input.InactiveFilter != null, r => r.Inactive == input.InactiveFilter)
                                 .OrderBy(o => o.SortOrder).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<ServiceGroupDto>> GetById(Guid id)
        {
            var result = new ResultDto<ServiceGroupDto>();

            try
            {
                var service = _serviceGroupRepository.FirstOrDefault(s => s.Id == id);
                result.Result = ObjectMapper.Map<ServiceGroupDto>(service);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }
    }
}
