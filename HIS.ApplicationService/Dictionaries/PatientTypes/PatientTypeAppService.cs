using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.PatientTypes;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.PatientTypes
{
    public class PatientTypeAppService : BaseCrudAppService<PatientTypeDto, int, GetAllPatientTypeInput>, IPatientTypeAppService
    {
        public PatientTypeAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<PatientTypeDto>> Create(PatientTypeDto input)
        {
            var result = new ResultDto<PatientTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = NewID();
                    var data = ObjectMapper.Map<PatientType>(input);
                    data.CreatedDate = DateTime.Now;
                    data.CreatedBy = SessionExtensions.Login?.Id;
                    Context.PatientTypes.Add(data);
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

        public async override Task<ResultDto<PatientTypeDto>> Update(PatientTypeDto input)
        {
            var result = new ResultDto<PatientTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var patientType = await Context.PatientTypes.FindAsync(input.Id);
                    var data = ObjectMapper.Map<PatientType>(input);
                    data.CreatedDate = patientType.CreatedDate;
                    data.CreatedBy = patientType.CreatedBy;
                    data.ModifiedDate = DateTime.Now;
                    data.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.PatientTypes.Update(data);
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

        public async override Task<ResultDto<PatientTypeDto>> Delete(int id)
        {
            var result = new ResultDto<PatientTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var patientType = await Context.PatientTypes.FindAsync(id);
                    Context.PatientTypes.Remove(patientType);

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

        public async override Task<PagedResultDto<PatientTypeDto>> GetAll(GetAllPatientTypeInput input)
        {
            var result = new PagedResultDto<PatientTypeDto>();
            try
            {
                var filter = Context.PatientTypes.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.PatientTypeCodeFilter), x => x.PatientTypeCode == input.PatientTypeCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.PatientTypeNameFilter), x => x.PatientTypeName == input.PatientTypeNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(s => s.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<PatientTypeDto>>(paged.ToList());
                result.IsSuccessed = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<PatientTypeDto>> GetById(int id)
        {
            var result = new ResultDto<PatientTypeDto>();
            try
            {
                var patientType = await Context.PatientTypes.FindAsync(id);
                result.Item = ObjectMapper.Map<PatientTypeDto>(patientType);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        private int NewID()
        {
            var data = Context.PatientTypes.DefaultIfEmpty().Max(x => x.Id);
            return data + 1;
        }
    }
}
