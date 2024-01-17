using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Linq.Extensions;
using HIS.Core.Services.Dto;
using HIS.Dtos.Business.Patients;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Business.Patients
{
    public class PatientAppService : BaseCrudAppService<PatientDto, Guid, GetAllPatientInputDto>, IPatientAppService
    {
        public PatientAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<PatientDto>> Create(PatientDto input)
        {
            var result = new ResultDto<PatientDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<Patient>(input);
                    data.CreatedDate = DateTime.Now;
                    data.CreatedBy = SessionExtensions.Login?.Id;
                    Context.Patients.Add(data);
                    await SaveChangesAsync();
                    await transaction.CommitAsync();

                    result.IsSucceeded = true;
                    result.Result = input;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public override Task<ResultDto<PatientDto>> Update(PatientDto input)
        {
            throw new NotImplementedException();
        }

        public async override Task<ResultDto<PatientDto>> Delete(Guid id)
        {
            var result = new ResultDto<PatientDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var data = await Context.Patients.FindAsync(id);
                    Context.Patients.Remove(data);

                    await SaveChangesAsync();
                    transaction.Commit();

                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public override async Task<PagedResultDto<PatientDto>> GetAll(GetAllPatientInputDto input)
        {
            var result = new PagedResultDto<PatientDto>();
            try
            {
                var filter = Context.Patients
                    .WhereIf(!string.IsNullOrEmpty(input.PatientCodeFilter), x => x.PatientCode == input.PatientCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.PatientNameFilter), x => x.PatientName == input.PatientNameFilter)
                    .WhereIf(input.MaxBirthYear != null, x => x.BirthYear <= input.MaxBirthYear)
                    .WhereIf(input.MinBirthYear != null, x => x.BirthYear >= input.MinBirthYear)
                    .WhereIf(input.MaxBirthDate != null, x => x.BirthDate <= input.MaxBirthDate)
                    .WhereIf(input.MinBirthDate != null, x => x.BirthDate >= input.MinBirthDate)
                    .WhereIf(!string.IsNullOrEmpty(input.BirthplaceFilter), x => x.Birthplace == input.BirthplaceFilter)
                    .WhereIf(input.GenderFilter != null, x => x.GenderId == input.GenderFilter)
                    .WhereIf(input.EthnicFilter != null, x => x.EthnicId == input.EthnicFilter)
                    .WhereIf(input.ReligionFilter != null, x => x.ReligionId == input.ReligionFilter)
                    .WhereIf(input.CountryFilter != null, x => x.CountryId == input.CountryFilter)
                    .WhereIf(input.ProvinceFilter != null, x => x.ProvinceId == input.ProvinceFilter)
                    .WhereIf(input.DistrictFilter != null, x => x.DistrictId == input.DistrictFilter)
                    .WhereIf(input.WardFilter != null, x => x.WardId == input.WardFilter)
                    .WhereIf(input.CareerFilter != null, x => x.CareerId == input.CareerFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.WorkplaceFilter), x => x.Workplace == input.WorkplaceFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.IdentificationNumberFilter), x => x.IdentificationNumber == input.IdentificationNumberFilter)
                    .WhereIf(input.MaxIssueDateFilter != null, x => x.IssueDate <= input.MaxIssueDateFilter)
                    .WhereIf(input.MinIssueDateFilter != null, x => x.IssueDate >= input.MinIssueDateFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.IssueByFilter), x => x.IssueBy == input.IssueByFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.TelFilter), x => x.Tel == input.TelFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.MobileFilter), x => x.Mobile == input.MobileFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.EmailFilter), x => x.Email == input.EmailFilter);

                var paged = filter.OrderBy(s => s.PatientCode).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<PatientDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<PatientDto>> GetById(Guid id)
        {
            var result = new ResultDto<PatientDto>();
            try
            {
                var data = await Context.Patients.FindAsync(id);
                result.Result = ObjectMapper.Map<PatientDto>(data);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        
    }
}
