using AutoMapper;
using HIS.ApplicationService.Dictionaries.Branch;
using HIS.Dtos.Business.Patient;
using HIS.Dtos.Business.Treatment;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.District;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Business.Patients;
using HIS.EntityFrameworkCore.Entities.Business.Treatment;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Patient
{
    public class SPatientService : BaseSerivce, ISPatientService
    {
        public SPatientService(HIS_DbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper)
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

        public Task<ApiResultList<SPatientDto>> GetAll(GetAllSPatientInput input)
        {
            throw new NotImplementedException();
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

                        var patient = _mapper.Map<SPatient>(input);
                        patient.Id = input.PatientId.Value;
                        patient.Code = input.PatientCode;
                        patient.FullName = input.PatientName;

                        _dbContext.SPatients.Add(patient);
                        await _dbContext.SaveChangesAsync();
                    }

                    input.Code = "DT00000001";
                    var data = _mapper.Map<STreatment>(input);
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
