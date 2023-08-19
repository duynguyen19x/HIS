using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Business.Patient;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Linq;
using HIS.Dtos.Business.Patient;
using HIS.Dtos.Business.PatientRecord;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.PatientRecord
{
    public class PatientRecordAppService : BaseCrudAppService, IPatientRecordAppService
    {
        private readonly IPatientAppService _patientAppService;

        public PatientRecordAppService(
            IPatientAppService patientAppService,
            HISDbContext context
            , IMapper mapper) 
            : base(context, mapper)
        {
            _patientAppService = patientAppService;
        }

        public async Task<PagedResultDto<PatientRecordDto>> GetAll(GetAllPatientRecordInputDto input)
        {
            var result = new PagedResultDto<PatientRecordDto>();
            try
            {
                var filter = Context.PatientRecords.AsQueryable()
                    .Include(x => x.PatientFk)
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code.ToUpper() == input.CodeFilter.ToUpper())
                    .WhereIf(input.PatientIdFilter != null, x => x.PatientId == input.PatientIdFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.PatientNameFilter), x => x.PatientName.ToUpper() == input.PatientNameFilter.ToUpper())
                    .WhereIf(input.GenderIdFilter != null, x => x.GenderId == input.GenderIdFilter)
                    .WhereIf(input.EthnicityIdFilter != null, x => x.EthnicityId == input.EthnicityIdFilter)
                    .WhereIf(input.CareerIdFilter != null, x => x.CareerId == input.CareerIdFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                result.TotalCount = await filter.CountAsync();
                result.Items = (from o in filter

                                join o1 in Context.Patients on o.PatientId equals o1.Id 

                                select new PatientRecordDto()
                                {
                                    Id = o.Id,
                                    Code = o.Code,
                                    PatientId = o.PatientId,
                                    PatientName = o.PatientName,
                                    BirthDate = o.BirthDate,
                                    BirthYear = o.BirthYear,
                                    BirthPlace = o.BirthPlace,
                                    IdentificationNumber = o.IdentificationNumber,
                                    IssueBy = o.IssueBy,
                                    IssueDate = o.IssueDate,
                                    GenderId = o.GenderId,
                                    EthnicityId = o.EthnicityId,
                                    CareerId = o.CareerId,
                                    CountryId = o.CountryId,
                                    ProvinceId = o.ProvinceId,
                                    DistrictId = o.DistrictId,
                                    WardId = o.WardId,
                                    Address = o.Address,
                                    Tel = o.Tel,
                                    Mobile = o.Mobile,
                                    Fax = o.Fax,
                                    Email = o.Email,
                                    PatientTypeId = o.PatientTypeId,
                                    PatientRecordTypeId = o.PatientRecordTypeId,

                                    Description = o.Description,
                                    Inactive = o.Inactive
                                })
                                .PageBy(input)
                                .OrderBy(x => x.Code)
                                .ToList();
            }
            catch (Exception ex)
            {
                result.IsSuccessed = true;
                result.Message = ex.Message;
            }
            return await Task.FromResult(result);
        }

        public async Task<ResultDto<PatientRecordDto>> GetById(Guid id)
        {
            var result = new ResultDto<PatientRecordDto>();
            try
            {
                result.Item = Mapper.Map<PatientRecordDto>(await Context.PatientRecords.SingleOrDefaultAsync(p => p.Id == id));
            }
            catch (Exception ex)
            {
                result.IsSuccessed = true;
                result.Message = ex.Message;
            }
            return await Task.FromResult(result);
        }

        public async Task<ResultDto<PatientRecordDto>> Create(PatientRecordDto input)
        {
            var result = new ResultDto<PatientRecordDto>();
            await Context.TransactionAsync(async () =>
            {
                try
                {
                    // thêm mới hoặc cập nhật thông tin bệnh nhân
                    var patientResult = await _patientAppService.CreateOrEdit(Mapper.Map<PatientDto>(input));
                    if (patientResult.IsSuccessed)
                    {
                        input.PatientId = patientResult.Item.Id;
                        input.PatientCode = patientResult.Item.Code;
                    }

                    // thêm mới đợt điều trị
                    input.Id = Guid.NewGuid();
                    if (string.IsNullOrEmpty(input.Code))
                        input.Code = "BA" + (Context.PatientRecords.Count() + 1).ToString().PadLeft(5, '0');
                    var patientRecord = Mapper.Map<EntityFrameworkCore.Entities.Business.PatientRecord>(input);
                    patientRecord.CreatedDate = DateTime.Now;
                    patientRecord.CreatedBy = Guid.NewGuid(); // giả lập tài khoản create
                    Context.Add(patientRecord);
                    await Context.SaveChangesAsync();
                    result.Item = input;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            });
            return result;
        }

        public Task<ResultDto<PatientRecordDto>> Update(PatientRecordDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<PatientRecordDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
