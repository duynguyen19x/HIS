using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Linq.Extensions;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionaries.ServicePricePolicy
{
    public class ServicePricePolicyService : BaseCrudAppService<ServicePricePolicyDto, Guid?, GetAllServicePricePolicyInput>, IServicePricePolicyService
    {
        public ServicePricePolicyService(HISDbContext dbContext, IConfiguration config, IMapper mapper) 
            : base(dbContext, mapper)
        {

        }

        public override Task<ResultDto<ServicePricePolicyDto>> Create(ServicePricePolicyDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<ServicePricePolicyDto>> Update(ServicePricePolicyDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<ServicePricePolicyDto>> Delete(Guid? id)
        {
            throw new NotImplementedException();
        }

        public override async Task<PagedResultDto<ServicePricePolicyDto>> GetAll(GetAllServicePricePolicyInput input)
        {
            var result = new PagedResultDto<ServicePricePolicyDto>();

            try
            {
                result.Result = (from r in Context.PatientTypes
                                 select new ServicePricePolicyDto()
                                 {
                                     PatientTypeId = r.Id,
                                     PatientTypeCode = r.PatientTypeCode,
                                     PatientTypeName = r.PatientTypeName,
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

        public override Task<ResultDto<ServicePricePolicyDto>> GetById(Guid? id)
        {
            throw new NotImplementedException();
        }

    }
}
