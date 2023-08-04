using AutoMapper;
using AutoMapper.Internal.Mappers;
using HIS.ApplicationService.Base;
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
        private readonly IRepository<SPatient, Guid> _patientRepository;
        private readonly HISDbContext _dbContext;

        public SPatientAppService(
            IRepository<SPatient, Guid> patientRepository,
            HISDbContext dbContext, 
            IConfiguration config, 
            IMapper mapper)
            //: base(dbContext, config, mapper)
        {
            _dbContext = dbContext;
            _patientRepository = patientRepository;
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
            var patient = await _patientRepository.GetAll().ToListAsync();

            var result = new ApiResultList<SPatientDto>();
            result.Result = ObjectMapper.Map<List<SPatientDto>>(patient);
            return result;
        }

        public Task<ApiResult<SPatientDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
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
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    

                    if (input.PatientId == null || input.PatientId == default(Guid))
                    {
                        input.PatientId = Guid.NewGuid();
                        if (string.IsNullOrEmpty(input.PatientCode))
                            input.PatientCode = "BN0000001";

                        var patient = ObjectMapper.Map<EntityFrameworkCore.Entities.Business.Patients.SPatient>(input);
                        patient.Id = input.PatientId.Value;
                        patient.Code = input.PatientCode;
                        //patient.FullName = input.PatientName;

                        _dbContext.SPatients.Add(patient);
                        await _dbContext.SaveChangesAsync();
                    }

                    input.Code = "DT00000001";
                    var data = ObjectMapper.Map<STreatment>(input);
                    _dbContext.STreatments.Add(data);
                    await _dbContext.SaveChangesAsync();

                    result.IsSuccessed = true;
                    result.Result = input;

                    transaction.Commit();
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
