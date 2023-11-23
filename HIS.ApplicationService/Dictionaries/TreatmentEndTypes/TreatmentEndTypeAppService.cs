using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.TreatmentEndTypes;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.TreatmentEndTypes
{
    public class TreatmentEndTypeAppService : BaseCrudAppService<TreatmentEndTypeDto, int, GetAllTreatmentEndTypeInput>, ITreatmentEndTypeAppService
    {
        public TreatmentEndTypeAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<TreatmentEndTypeDto>> Create(TreatmentEndTypeDto input)
        {
            var result = new ResultDto<TreatmentEndTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = Context.NewID<TreatmentEndType>();
                    var data = ObjectMapper.Map<TreatmentEndType>(input);
                    data.CreatedDate = DateTime.Now;
                    data.CreatedBy = SessionExtensions.Login?.Id;
                    Context.TreatmentEndTypes.Add(data);
                    await SaveChangesAsync();
                    await transaction.CommitAsync();

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

        public async override Task<ResultDto<TreatmentEndTypeDto>> Update(TreatmentEndTypeDto input)
        {
            var result = new ResultDto<TreatmentEndTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var treatmentEndType = await Context.TreatmentEndTypes.FindAsync(input.Id);
                    var data = ObjectMapper.Map<TreatmentEndType>(input);
                    data.CreatedDate = treatmentEndType.CreatedDate;
                    data.CreatedBy = treatmentEndType.CreatedBy;
                    data.ModifiedDate = DateTime.Now;
                    data.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.TreatmentEndTypes.Update(data);
                    await SaveChangesAsync();
                    await transaction.CommitAsync();

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

        public async override Task<ResultDto<TreatmentEndTypeDto>> Delete(int id)
        {
            var result = new ResultDto<TreatmentEndTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var treatmentEndType = await Context.TreatmentEndTypes.FindAsync(id);
                    Context.TreatmentEndTypes.Remove(treatmentEndType);

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

        public async override Task<PagedResultDto<TreatmentEndTypeDto>> GetAll(GetAllTreatmentEndTypeInput input)
        {
            var result = new PagedResultDto<TreatmentEndTypeDto>();
            try
            {
                var filter = Context.TreatmentEndTypes.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.TreatmentEndTypeCodeFilter), x => x.TreatmentEndTypeCode == input.TreatmentEndTypeCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.TreatmentEndTypeNameFilter), x => x.TreatmentEndTypeName == input.TreatmentEndTypeNameFilter)
                    .WhereIf(input.IsForOutPatientFilter != null, x => x.IsForOutPatient == input.IsForOutPatientFilter)
                    .WhereIf(input.IsForInPatientFilter != null, x => x.IsForInPatient == input.IsForInPatientFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(s => s.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<TreatmentEndTypeDto>>(paged.ToList());
                result.IsSuccessed = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<TreatmentEndTypeDto>> GetById(int id)
        {
            var result = new ResultDto<TreatmentEndTypeDto>();
            try
            {
                var treatmentEndType = await Context.TreatmentEndTypes.FindAsync(id);
                result.Item = ObjectMapper.Map<TreatmentEndTypeDto>(treatmentEndType);
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
