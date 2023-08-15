using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicinePricePolicy;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.MedicinePricePolicy
{
    public class SMedicinePricePolicyService : BaseSerivce, ISMedicinePricePolicyService
    {
        public SMedicinePricePolicyService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
           : base(dbContext, config, mapper)
        {

        }

        public Task<ApiResult<SMedicinePricePolicyDto>> CreateOrEdit(SMedicinePricePolicyDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<SMedicinePricePolicyDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResultList<SMedicinePricePolicyDto>> GetAll(GetAllSMedicinePricePolicyInput input)
        {
            var result = new ApiResultList<SMedicinePricePolicyDto>();

            try
            {
                result.Result = (from r in _dbContext.SPatientTypes
                                 select new SMedicinePricePolicyDto()
                                 {
                                     PatientTypeId = r.Id,
                                     PatientTypeCode = r.Code,
                                     PatientTypeName = r.Name,
                                     IsHeIn = r.Code == PatientTypes.BHYT ? true : false,
                                     Inactive = r.Inactive,
                                 })
                                 .WhereIf(input.InactiveFilter != null, w => w.Inactive == input.InactiveFilter)
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(input.MedicineIdFilter), w => w.MedicineId == input.MedicineIdFilter)
                                 .WhereIf(input.PatientTypeIdFilter != null, w => w.PatientTypeId == input.PatientTypeIdFilter)
                                 .OrderBy(o => o.PatientTypeCode).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public Task<ApiResult<SMedicinePricePolicyDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
