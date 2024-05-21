using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.Core.Application.Services;
using HIS.ApplicationService.Dictionary.ServicePricePolicies.Dto;
using HIS.EntityFrameworkCore.Entities;

namespace HIS.ApplicationService.Dictionary.ServicePricePolicies
{
    public class ServicePricePolicyService : BaseAppService, IServicePricePolicyService
    {
        private readonly IRepository<ServicePricePolicy, Guid> _servicePricePolicyRepository;
        private readonly IRepository<PatientObjectType, int> _patientObjectTypeRepository;

        public ServicePricePolicyService(
            IRepository<ServicePricePolicy, Guid> servicePricePolicyRepository,
            IRepository<PatientObjectType, int> patientObjectTypeRepository) 
        {
            _servicePricePolicyRepository = servicePricePolicyRepository;
            _patientObjectTypeRepository = patientObjectTypeRepository;
        }

        public virtual async Task<ResultDto<ServicePricePolicyDto>> CreateOrEdit(ServicePricePolicyDto input)
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

        public virtual Task<ResultDto<ServicePricePolicyDto>> Create(ServicePricePolicyDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<ServicePricePolicyDto>> Update(ServicePricePolicyDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<ServicePricePolicyDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<PagedResultDto<ServicePricePolicyDto>> GetAll(GetAllServicePricePolicyInput input)
        {
            var result = new PagedResultDto<ServicePricePolicyDto>();
            try
            {
                result.Result = (from r in _patientObjectTypeRepository.GetAll()
                                 select new ServicePricePolicyDto()
                                 {
                                     PatientTypeId = r.Id,
                                     PatientTypeCode = r.Code,
                                     PatientTypeName = r.Name,
                                     Inactive = r.Inactive,
                                 })
                                 .WhereIf(input.InactiveFilter != null, w => w.Inactive == input.InactiveFilter)
                                 .OrderBy(o => o.PatientTypeCode).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public virtual Task<ResultDto<ServicePricePolicyDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}
