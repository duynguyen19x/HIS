using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.PatientObjectTypes;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.PatientObjectTypes
{
    public class PatientObjectTypeAppService : BaseCrudAppService<PatientObjectTypeDto, int, GetAllPatientObjectTypeInput>, IPatientObjectTypeAppService
    {
        public PatientObjectTypeAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<PatientObjectTypeDto>> Create(PatientObjectTypeDto input)
        {
            var result = new ResultDto<PatientObjectTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = NewID();
                    var data = ObjectMapper.Map<PatientObjectType>(input);
                    data.CreatedDate = DateTime.Now;
                    data.CreatedBy = SessionExtensions.Login?.Id;
                    Context.PatientObjectTypes.Add(data);
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

        public async override Task<ResultDto<PatientObjectTypeDto>> Update(PatientObjectTypeDto input)
        {
            var result = new ResultDto<PatientObjectTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var patientObjectType = await Context.PatientObjectTypes.FindAsync(input.Id);
                    var data = ObjectMapper.Map<PatientObjectType>(input);
                    data.CreatedDate = patientObjectType.CreatedDate;
                    data.CreatedBy = patientObjectType.CreatedBy;
                    data.ModifiedDate = DateTime.Now;
                    data.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.PatientObjectTypes.Update(data);
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

        public async override Task<ResultDto<PatientObjectTypeDto>> Delete(int id)
        {
            var result = new ResultDto<PatientObjectTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var patientObjectType = await Context.PatientObjectTypes.FindAsync(id);
                    Context.PatientObjectTypes.Remove(patientObjectType);

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

        public async override Task<PagedResultDto<PatientObjectTypeDto>> GetAll(GetAllPatientObjectTypeInput input)
        {
            var result = new PagedResultDto<PatientObjectTypeDto>();
            try
            {
                var filter = Context.PatientObjectTypes.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.PatientObjectTypeCodeFilter), x => x.PatientObjectTypeCode == input.PatientObjectTypeCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.PatientObjectTypeNameFilter), x => x.PatientObjectTypeName == input.PatientObjectTypeNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(s => s.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<PatientObjectTypeDto>>(paged.ToList());
                result.IsSuccessed = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<PatientObjectTypeDto>> GetById(int id)
        {
            var result = new ResultDto<PatientObjectTypeDto>();
            try
            {
                var patientObjectType = await Context.PatientObjectTypes.FindAsync(id);
                result.Item = ObjectMapper.Map<PatientObjectTypeDto>(patientObjectType);
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
            var data = Context.PatientObjectTypes.DefaultIfEmpty().Max(x => x.Id);
            return data + 1;
        }
    }
}
