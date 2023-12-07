using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.Ward;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.Wards
{
    public class WardAppService : BaseCrudAppService<WardDto, Guid, GetAllWardInput>, IWardAppService
    {
        public WardAppService(HISDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public override async Task<ResultDto<WardDto>> Create(WardDto input)
        {
            var result = new ResultDto<WardDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<Ward>(input);
                    Context.Wards.Add(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<WardDto>> Update(WardDto input)
        {
            var result = new ResultDto<WardDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = ObjectMapper.Map<Ward>(input);
                    Context.Wards.Update(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<WardDto>> Delete(Guid id)
        {
            var result = new ResultDto<WardDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = Context.Wards.SingleOrDefault(x => x.Id == id);
                    if (data != null)
                    {
                        Context.Wards.Remove(data);
                        await Context.SaveChangesAsync();
                        result.IsSucceeded = true;

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<PagedResultDto<WardDto>> GetAll(GetAllWardInput input)
        {
            var result = new PagedResultDto<WardDto>();
            try
            {
                var filter = Context.Wards.AsNoTracking()
                    .WhereIf(string.IsNullOrEmpty(input.WardCodeFilter), x => x.WardCode == input.WardCodeFilter)
                    .WhereIf(string.IsNullOrEmpty(input.WardNameFilter), x => x.WardName == input.WardNameFilter)
                    .WhereIf(string.IsNullOrEmpty(input.ShortTextFilter), x => x.ShortText == input.ShortTextFilter)
                    .WhereIf(input.DistrictFilter != null, x => x.DistrictId == input.DistrictFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = await filter.OrderBy(s => s.SortOrder).PageBy(input).ToListAsync();

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<WardDto>>(paged);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<WardDto>> GetById(Guid id)
        {
            var result = new ResultDto<WardDto>();

            var data = Context.Wards.SingleOrDefault(s => s.Id == id);
            if (data != null)
            {
                result.Result = ObjectMapper.Map<WardDto>(data);
            }

            return await Task.FromResult(result);
        }
    }
}
