using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.DeathCauses;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.DeathCauses
{
    public class DeathCauseAppService : BaseCrudAppService<DeathCauseDto, Guid, GetAllDeathCauseInput>, IDeathCauseAppService
    {
        public DeathCauseAppService(HISDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async override Task<ResultDto<DeathCauseDto>> Create(DeathCauseDto input)
        {
            var result = new ResultDto<DeathCauseDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<DeathCause>(input);
                    data.CreatedDate = DateTime.Now;
                    data.CreatedBy = SessionExtensions.Login?.Id;
                    Context.DeathCauses.Add(data);
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

        public async override Task<ResultDto<DeathCauseDto>> Update(DeathCauseDto input)
        {
            var result = new ResultDto<DeathCauseDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var deathCause = await Context.DeathCauses.FindAsync(input.Id);
                    var data = ObjectMapper.Map<DeathCause>(input);
                    data.CreatedDate = deathCause.CreatedDate;
                    data.CreatedBy = deathCause.CreatedBy;
                    data.ModifiedDate = DateTime.Now;
                    data.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.DeathCauses.Update(data);
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

        public async override Task<ResultDto<DeathCauseDto>> Delete(Guid id)
        {
            var result = new ResultDto<DeathCauseDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var deathCause = await Context.DeathCauses.FindAsync(id);
                    Context.DeathCauses.Remove(deathCause);

                    await SaveChangesAsync();
                    await transaction.CommitAsync();

                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async override Task<PagedResultDto<DeathCauseDto>> GetAll(GetAllDeathCauseInput input)
        {
            var result = new PagedResultDto<DeathCauseDto>();
            try
            {
                var filter = Context.DeathCauses.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.DeathCauseCodeFilter), x => x.DeathCauseCode == input.DeathCauseCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.DeathCauseNameFilter), x => x.DeathCauseName == input.DeathCauseNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(s => s.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<DeathCauseDto>>(paged.ToList());
                result.IsSuccessed = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<DeathCauseDto>> GetById(Guid id)
        {
            var result = new ResultDto<DeathCauseDto>();
            try
            {
                var deathCause = await Context.DeathCauses.FindAsync(id);
                result.Item = ObjectMapper.Map<DeathCauseDto>(deathCause);
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
