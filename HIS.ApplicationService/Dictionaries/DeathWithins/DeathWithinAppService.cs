using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.DeathCauses;
using HIS.Dtos.Dictionaries.DeathWithins;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.DeathWithins
{
    public class DeathWithinAppService : BaseCrudAppService<DeathWithinDto, Guid, GetAllDeathWithinInput>, IDeathWithinAppService
    {
        public DeathWithinAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<DeathWithinDto>> Create(DeathWithinDto input)
        {
            var result = new ResultDto<DeathWithinDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<DeathWithin>(input);
                    data.CreatedDate = DateTime.Now;
                    data.CreatedBy = SessionExtensions.Login?.Id;
                    Context.DeathWithins.Add(data);
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

        public async override Task<ResultDto<DeathWithinDto>> Update(DeathWithinDto input)
        {
            var result = new ResultDto<DeathWithinDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var deathWithin = await Context.DeathWithins.FindAsync(input.Id);
                    var data = ObjectMapper.Map<DeathWithin>(input);
                    data.CreatedDate = deathWithin.CreatedDate;
                    data.CreatedBy = deathWithin.CreatedBy;
                    data.ModifiedDate = DateTime.Now;
                    data.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.DeathWithins.Update(data);
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

        public async override Task<ResultDto<DeathWithinDto>> Delete(Guid id)
        {
            var result = new ResultDto<DeathWithinDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var deathCause = await Context.DeathWithins.FindAsync(id);
                    Context.DeathWithins.Remove(deathCause);

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

        public async override Task<PagedResultDto<DeathWithinDto>> GetAll(GetAllDeathWithinInput input)
        {
            var result = new PagedResultDto<DeathWithinDto>();
            try
            {
                var filter = Context.DeathWithins.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.DeathWithinCodeFilter), x => x.DeathWithinCode == input.DeathWithinCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.DeathWithinNameFilter), x => x.DeathWithinName == input.DeathWithinNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(s => s.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<DeathWithinDto>>(paged.ToList());
                result.IsSuccessed = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<DeathWithinDto>> GetById(Guid id)
        {
            var result = new ResultDto<DeathWithinDto>();
            try
            {
                var deathWithin = await Context.DeathWithins.FindAsync(id);
                result.Item = ObjectMapper.Map<DeathWithinDto>(deathWithin);
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
