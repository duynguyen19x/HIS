using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Linq;
using HIS.Core.Repositories;
using HIS.Dtos.Business.Patient;
using HIS.Dtos.Business.Treatment;
using HIS.Dtos.Commons;
using HIS.EntityFrameworkCore.Entities.Business.Patients;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Business.Patient
{
    public class SPatientAppService : BaseAppService, ISPatientService
    {
        public SPatientAppService(HISDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public Task<ApiResult<SPatientDto>> CreateOrEdit(SPatientDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<SPatientDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResultList<SPatientDto>> GetAll(GetAllSPatientInput input)
        {
            var result = new ApiResultList<SPatientDto>();
            var patients = await Context.SPatients
                .WhereIf(string.IsNullOrEmpty(input.PatientCodeFilter), x => x.Code == input.PatientCodeFilter)
                .ToListAsync();
            result.Result = Mapper.Map<List<SPatientDto>>(patients);
            return result;
        }

        public async Task<ApiResult<SPatientDto>> GetById(Guid id)
        {
            var result = new ApiResult<SPatientDto>();
            var patient = await Context.SPatients.FirstOrDefaultAsync(x => x.Id == id);
            result.Result = Mapper.Map<SPatientDto>(patient);
            return result;
        }

        public async Task<ApiResult<STreatmentDto>> RegisterOrEdit(STreatmentDto input)
        {
            if (input.Id == null)
                return await Register(input);
            else
                return new ApiResult<STreatmentDto>();
        }

        public async Task<ApiResult<STreatmentDto>> Register(STreatmentDto input)
        {
            var result = new ApiResult<STreatmentDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

    }
}
