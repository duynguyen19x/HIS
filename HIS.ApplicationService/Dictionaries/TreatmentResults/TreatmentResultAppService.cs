using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.Ethnicities;
using HIS.Dtos.Dictionaries.TreatmentResults;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.TreatmentResults
{
    public class TreatmentResultAppService : BaseCrudAppService<TreatmentResultDto, int, GetAllTreatmentResultInput>, ITreatmentResultAppService
    {
        public TreatmentResultAppService(HISDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<TreatmentResultDto>> Create(TreatmentResultDto input)
        {
            var result = new ResultDto<TreatmentResultDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = Context.NewID<TreatmentResult>();
                    var data = ObjectMapper.Map<TreatmentResult>(input);
                    data.CreatedDate = DateTime.Now;
                    data.CreatedBy = SessionExtensions.Login?.Id;
                    Context.TreatmentResults.Add(data);
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

        public async override Task<ResultDto<TreatmentResultDto>> Update(TreatmentResultDto input)
        {
            var result = new ResultDto<TreatmentResultDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var ethnicity = await Context.TreatmentResults.FindAsync(input.Id);
                    var data = ObjectMapper.Map<TreatmentResult>(input);
                    data.CreatedDate = ethnicity.CreatedDate;
                    data.CreatedBy = ethnicity.CreatedBy;
                    data.ModifiedDate = DateTime.Now;
                    data.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.TreatmentResults.Update(data);
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

        public async override Task<ResultDto<TreatmentResultDto>> Delete(int id)
        {
            var result = new ResultDto<TreatmentResultDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var ethnicity = await Context.TreatmentResults.FindAsync(id);
                    Context.TreatmentResults.Remove(ethnicity);

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

        public async override Task<PagedResultDto<TreatmentResultDto>> GetAll(GetAllTreatmentResultInput input)
        {
            var result = new PagedResultDto<TreatmentResultDto>();
            try
            {
                var filter = Context.TreatmentResults.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.TreatmentResultCodeFilter), x => x.TreatmentResultCode == input.TreatmentResultCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.TreatmentResultNameFilter), x => x.TreatmentResultName == input.TreatmentResultNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(s => s.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<TreatmentResultDto>>(paged.ToList());
                result.IsSuccessed = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<TreatmentResultDto>> GetById(int id)
        {
            var result = new ResultDto<TreatmentResultDto>();
            try
            {
                var ethnicity = await Context.TreatmentResults.FindAsync(id);
                result.Item = ObjectMapper.Map<TreatmentResultDto>(ethnicity);
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
