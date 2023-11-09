using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Application.Core.Utils;
using HIS.Core.Linq;
using HIS.Dtos.Business.Patients;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Business.Patients
{
    public class PatientAppService : BaseCrudAppService<PatientDto, Guid, PagedPatientInputDto>, IPatientAppService
    {
        public PatientAppService(
            HISDbContext context, 
            IMapper mapper)
            : base(context, mapper)
        {
        }

        public override async Task<ResultDto<PatientDto>> Create(PatientDto input)
        {
            var result = new ResultDto<PatientDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    if (DataHelper.IsNullOrDefault(input.Code))
                        input.Code = "BN" + String.Format("{0:00000}", Context.Patients.Count() + 1);

                    var patient = ObjectMapper.Map<Patient>(input);
                    patient.CreatedDate = DateTime.Now;
                    patient.CreatedBy = SessionExtensions.Login?.Id;

                    Context.Patients.Add(patient);
                    await SaveChangesAsync();

                    result.Item = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public override async Task<ResultDto<PatientDto>> Update(PatientDto input)
        {
            var result = new ResultDto<PatientDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    var patient = ObjectMapper.Map<Patient>(input);
                    patient.ModifiedDate = DateTime.Now;
                    patient.ModifiedBy = SessionExtensions.Login?.Id;

                    Context.Patients.Update(patient);

                    result.Item = input;
                    await SaveChangesAsync();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public override async Task<ResultDto<PatientDto>> Delete(Guid id)
        {
            var result = new ResultDto<PatientDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    var patient = Context.Patients.SingleOrDefault(x => x.Id == id);
                    if (patient != null)
                    {
                        Context.Patients.Remove(patient);
                        await SaveChangesAsync();

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }    
            return result;
        }

        public override async Task<PagedResultDto<PatientDto>> GetAll(PagedPatientInputDto input)
        {
            var result = new PagedResultDto<PatientDto>();
            try
            {
                var filter = Context.Patients.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code.ToLower() == input.CodeFilter.ToLower())
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name.ToLower() == input.NameFilter.ToLower())
                    .WhereIf(input.MaxBirthDateFilter != null, x => x.BirthDate <= input.MinBirthDateFilter)
                    .WhereIf(input.MinBirthDateFilter != null, x => x.BirthDate >= input.MinBirthDateFilter)
                    .WhereIf(input.MaxBirthYearFilter != null, x => x.BirthYear >= input.MaxBirthYearFilter)
                    .WhereIf(input.MinBirthYearFilter != null, x => x.BirthYear >= input.MinBirthYearFilter)
                    .WhereIf(input.GenderIdFilter != null, x => x.GenderId == input.GenderIdFilter)
                    .WhereIf(input.CountryIdFilter != null, x => x.CountryId == input.CountryIdFilter)
                    .WhereIf(input.EthnicIdFilter != null, x => x.EthnicId == input.EthnicIdFilter)
                    .WhereIf(input.CareerIdFilter != null, x => x.CareerId == input.CareerIdFilter);
                var paged = await filter.PageBy(input).ToListAsync();
                var totalCount = await filter.CountAsync();

                result.Items = ObjectMapper.Map<IList<PatientDto>>(paged);
                result.TotalCount = totalCount;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return result;
        }

        public override async Task<ResultDto<PatientDto>> GetById(Guid id)
        {
            var result = new ResultDto<PatientDto>();
            try
            {
                result.Item = ObjectMapper.Map<PatientDto>(await Context.Patients.FindAsync(id));
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
