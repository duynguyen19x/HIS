using AutoMapper;
using HIS.Dtos.Business.Treatment;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Room;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Business.Patients;
using HIS.EntityFrameworkCore.Entities.Business.Treatment;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Patient
{
    public class STreatmentService : BaseSerivce, ISTreatmentService
    {
        public STreatmentService(HIS_DbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper) { }

        public async Task<ApiResult<STreatmentDto>> CreateOrEdit(STreatmentDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Edit(input);
        }

        public async Task<ApiResult<STreatmentDto>> Create(STreatmentDto input)
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

        public async Task<ApiResult<STreatmentDto>> Edit(STreatmentDto input)
        {
            var result = new ApiResult<STreatmentDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _mapper.Map<STreatment>(input);
                    _dbContext.STreatments.Update(data);
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

        public async Task<ApiResult<STreatmentDto>> Delete(Guid id)
        {
            var result = new ApiResult<STreatmentDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var department = _dbContext.STreatments.SingleOrDefault(x => x.Id == id);
                    if (department != null)
                    {
                        _dbContext.STreatments.Remove(department);
                        await _dbContext.SaveChangesAsync();
                        result.IsSuccessed = true;

                        transaction.Commit();
                    }
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

        public async Task<ApiResultList<STreatmentDto>> GetAll(GetAllSTreatmentInput input)
        {
            var result = new ApiResultList<STreatmentDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from t in _dbContext.STreatments
                                 join p in _dbContext.SPatients on t.PatientId equals p.Id
                                 where (string.IsNullOrEmpty(input.PatientCodeFilter) || p.FirstName == input.PatientNameFilter)
                                    && (string.IsNullOrEmpty(input.PatientCodeFilter) || p.Code == input.PatientCodeFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || t.Code == input.CodeFilter)
                                     && (input.MaxInTimeClinicalFilter == null || t.InTimeClinical <= input.MaxInTimeClinicalFilter)
                                     && (input.MinInTimeClinicalFilter == null || t.InTimeClinical >= input.MinInTimeClinicalFilter)
                                     && (input.MaxInTimeFilter == null || t.InTime <= input.MaxInTimeFilter)
                                     && (input.MinInTimeFilter == null || t.InTime >= input.MinInTimeFilter)
                                     && (input.MaxOutTimeFilter == null || t.OutTime <= input.MaxOutTimeFilter)
                                     && (input.MinOutTimeFilter == null || t.OutTime >= input.MinOutTimeFilter)
                                 select new STreatmentDto()
                                 {
                                     Id = t.Id,
                                     Code = t.Code,
                                     PatientCode = p.Code,
                                     PatientName = p.FullName,
                                     PatientId = t.PatientId,
                                     DOB = t.DOB,
                                     Year = t.Year,
                                     Address = t.Address,
                                     CareerId = t.CareerId,
                                     CountryId = t.CountryId.Value,
                                     DistrictId = t.DistrictId.Value,
                                     WardId = t.WardId,
                                     EthnicId = p.EthnicId.Value,
                                     GenderId = t.GenderId,
                                     IdentificationNumber = p.IdentificationNumber,
                                     InTime = t.InTime,
                                     InTimeClinical = t.InTimeClinical,
                                     OutTime = t.OutTime,
                                     PatientTypeId = p.PatientTypeId
                                 })
                                 .ToList();
                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<STreatmentDto>> GetById(Guid id)
        {
            var result = new ApiResult<STreatmentDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from t in _dbContext.STreatments
                                 join p in _dbContext.SPatients on t.PatientId equals p.Id
                                 where t.Id == id
                                 select new STreatmentDto()
                                 {
                                     Id = t.Id,
                                     Code = t.Code,
                                     PatientCode = p.Code,
                                     PatientName = p.FullName,
                                     PatientId = t.PatientId,
                                     DOB = t.DOB,
                                     Year = t.Year,
                                     Address = t.Address,
                                     CareerId = t.CareerId,
                                     CountryId = t.CountryId.Value,
                                     DistrictId = t.DistrictId.Value,
                                     WardId = t.WardId,
                                     EthnicId = p.EthnicId.Value,
                                     GenderId = t.GenderId,
                                     IdentificationNumber = p.IdentificationNumber,
                                     InTime = t.InTime,
                                     InTimeClinical = t.InTimeClinical,
                                     OutTime = t.OutTime,
                                     PatientTypeId = p.PatientTypeId
                                 })
                                 .SingleOrDefault();
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
    }
}
