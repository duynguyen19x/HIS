using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.Relatives;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.Relatives
{
    public class RelativeAppService : BaseCrudAppService<RelativeDto, Guid, GetAllRelativeInput>, IRelativeAppService
    {
        public RelativeAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<RelativeDto>> Create(RelativeDto input)
        {
            var result = new ResultDto<RelativeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<Relative>(input);
                    data.CreatedDate = DateTime.Now;
                    data.CreatedBy = SessionExtensions.Login?.Id;
                    Context.Relatives.Add(data);
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

        public async override Task<ResultDto<RelativeDto>> Update(RelativeDto input)
        {
            var result = new ResultDto<RelativeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var relative = await Context.Relatives.FindAsync(input.Id);
                    var data = ObjectMapper.Map<Relative>(input);
                    data.CreatedDate = relative.CreatedDate;
                    data.CreatedBy = relative.CreatedBy;
                    data.ModifiedDate = DateTime.Now;
                    data.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.Relatives.Update(data);
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

        public async override Task<ResultDto<RelativeDto>> Delete(Guid id)
        {
            var result = new ResultDto<RelativeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var relative = await Context.Relatives.FindAsync(id);
                    Context.Relatives.Remove(relative);

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

        public async override Task<PagedResultDto<RelativeDto>> GetAll(GetAllRelativeInput input)
        {
            var result = new PagedResultDto<RelativeDto>();
            try
            {
                var filter = Context.Relatives.AsQueryable()
                    .WhereIf(input.RelativeCategoryFilter != null, x => x.RelativeCategoryID == input.RelativeCategoryFilter)
                    .WhereIf(input.PatientRecordFilter != null, x => x.PatientRecordID == input.PatientRecordFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.RelativeNameFilter), x => x.RelativeName == input.RelativeNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(s => s.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<RelativeDto>>(paged.ToList());
                result.IsSuccessed = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<RelativeDto>> GetById(Guid id)
        {
            var result = new ResultDto<RelativeDto>();
            try
            {
                var relative = await Context.Relatives.FindAsync(id);
                result.Item = ObjectMapper.Map<RelativeDto>(relative);
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
