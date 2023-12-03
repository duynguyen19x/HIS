using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
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
                    transaction.Commit();

                    result.IsSucceeded = true;
                    result.Item = input;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async override Task<ResultDto<PatientDto>> Update(PatientDto input)
        {
            var result = new ResultDto<PatientDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var patient = await Context.Patients.FindAsync(input.Id);
                    var data = ObjectMapper.Map<Patient>(input);
                    data.CreatedDate = patient.CreatedDate;
                    data.CreatedBy = patient.CreatedBy;
                    data.ModifiedDate = DateTime.Now;
                    data.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.Patients.Update(data);
                    await SaveChangesAsync();
                    transaction.Commit();

                    result.IsSucceeded = true;
                    result.Item = input;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async override Task<ResultDto<PatientDto>> Delete(Guid id)
        {
            var result = new ResultDto<PatientDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var patient = await Context.Patients.FindAsync(id);
                    patient.IsDeleted = true;
                    Context.Patients.Update(patient);
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

        public async override Task<PagedResultDto<PatientDto>> GetAll(GetAllPatientInputDto input)
        {
            var result = new PagedResultDto<PatientDto>();
            try
            {
                var filter = Context.Patients.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.PatientCodeFilter), x => x.PatientCode == input.PatientCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.PatientNameFilter), x => x.PatientName == input.PatientNameFilter)
                    .WhereIf(input.MaxBirthDateFilter != null, x => x.BirthDate != null && x.BirthDate <= input.MaxBirthDateFilter)
                    .WhereIf(input.MinBirthDateFilter != null, x => x.BirthDate != null && x.BirthDate >= input.MinBirthDateFilter)
                    .WhereIf(input.MaxBirthYearFilter != null, x => x.BirthYear <= input.MaxBirthYearFilter)
                    .WhereIf(input.MinBirthYearFilter != null, x => x.BirthYear >= input.MinBirthYearFilter)
                    .WhereIf(string.IsNullOrEmpty(input.BirthPlaceFilter), x => x.Birthplace == input.BirthPlaceFilter)
                    .WhereIf(input.GenderFilter != null, x => x.GenderID == input.GenderFilter)
                    .WhereIf(input.EthnicityFilter != null, x => x.EthnicityID == input.EthnicityFilter)
                    .WhereIf(input.CountryFilter != null, x => x.CountryID == input.CountryFilter)
                    .WhereIf(input.ProvinceOrCityFilter != null, x => x.ProvinceOrCityID == input.ProvinceOrCityFilter)
                    .WhereIf(input.DistrictFilter != null, x => x.DistrictID == input.DistrictFilter)
                    .WhereIf(input.WardOrCommuneFilter != null, x => x.WardID == input.WardOrCommuneFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.AddressFilter), x => x.Address == input.AddressFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.TelFilter), x => x.Tel == input.TelFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.MobileFilter), x => x.Mobile == input.MobileFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.IdentificationNumberFilter), x => x.IdentificationNumber == input.IdentificationNumberFilter);

                var paged = filter.OrderBy(s => s.PatientCode).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<PatientDto>>(paged.ToList());
                result.IsSuccessed = true;
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
                result.Item = ObjectMapper.Map<PatientDto>(await Context.Relatives.FindAsync(id));
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
