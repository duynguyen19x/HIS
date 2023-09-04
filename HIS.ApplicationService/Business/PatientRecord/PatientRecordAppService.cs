using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Linq;
using HIS.Dtos.Business;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Business
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
                    .WhereIf(input.PatientIdFilter != null, x => x.PatientID == input.PatientIdFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.PatientNameFilter), x => x.PatientName.ToUpper() == input.PatientNameFilter.ToUpper())
                    .WhereIf(input.GenderIdFilter != null, x => x.GenderID == input.GenderIdFilter)
                    .WhereIf(input.EthnicityIdFilter != null, x => x.EthnicityID == input.EthnicityIdFilter)
                    .WhereIf(input.CareerIdFilter != null, x => x.CareerID == input.CareerIdFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                result.TotalCount = await filter.CountAsync();
                result.Items = (from o in filter

                                join o1 in Context.Patients on o.PatientID equals o1.Id 

                                select new PatientRecordDto()
                                {
                                    Id = o.Id,
                                    Code = o.Code,
                                    PatientId = o.PatientID,
                                    PatientName = o.PatientName,
                                    BirthDate = o.BirthDate,
                                    BirthYear = o.BirthYear,
                                    BirthPlace = o.BirthPlace,
                                    IdentificationNumber = o.IdentificationNumber,
                                    IssueBy = o.IssueBy,
                                    IssueDate = o.IssueDate,
                                    GenderId = o.GenderID,
                                    EthnicityId = o.EthnicityID,
                                    CareerId = o.CareerID,
                                    CountryId = o.CountryID,
                                    ProvinceId = o.ProvinceID,
                                    DistrictId = o.DistrictID,
                                    WardId = o.WardID,
                                    Address = o.Address,
                                    Tel = o.Tel,
                                    Mobile = o.Mobile,
                                    Fax = o.Fax,
                                    Email = o.Email,
                                    PatientTypeId = o.PatientTypeID,
                                    PatientRecordTypeId = o.PatientRecordTypeID,

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

        public async Task<ResultDto<PatientRecordDto>> CreateOrEdit(PatientRecordDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ResultDto<PatientRecordDto>> Create(PatientRecordDto input)
        {
            return await Context.UsingTransactionAsync<ResultDto<PatientRecordDto>>(async result =>
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
        }

        public async Task<ResultDto<PatientRecordDto>> Update(PatientRecordDto input)
        {
            return await Context.UsingTransactionAsync<ResultDto<PatientRecordDto>>(async result =>
            {
                try
                {
                    // kiểm tra dữ liệu 

                    // 
                    // thêm mới hoặc cập nhật thông tin bệnh nhân
                    var patientResult = await _patientAppService.CreateOrEdit(Mapper.Map<PatientDto>(input));
                    if (patientResult.IsSuccessed)
                    {
                        input.PatientId = patientResult.Item.Id;
                        input.PatientCode = patientResult.Item.Code;
                    }

                    if (string.IsNullOrEmpty(input.Code))
                        input.Code = "BA" + DateTime.Now.Year + Context.Patients.Count().ToString().PadLeft(5, '0');
                    var patientRecord = Mapper.Map<PatientRecord>(input);
                    patientRecord.ModifiedDate = DateTime.Now;
                    patientRecord.ModifiedBy = Guid.NewGuid(); // giả lập tài khoản update
                    Context.Update(patientRecord);

                    await Context.SaveChangesAsync();
                    result.Item = input;


                    await Context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);   
                }
            });
        }

        public async Task<ResultDto<PatientRecordDto>> Delete(Guid id)
        {
            return await Context.UsingTransactionAsync<ResultDto<PatientRecordDto>>(async result =>
            {
                try
                {
                    var patientRecord = Context.PatientRecords.SingleOrDefault(x => x.Id == id);
                    if (patientRecord != null)
                    {
                        Context.Remove(patientRecord);
                        await Context.SaveChangesAsync();
                    }
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            });
        }
    }
}
