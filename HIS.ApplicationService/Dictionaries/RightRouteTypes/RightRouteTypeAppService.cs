using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Services.Dto;
using HIS.Core.Linq.Extensions;
using HIS.Dtos.Dictionaries.RightRouteTypes;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.RightRouteTypes
{
    public class RightRouteTypeAppService : BaseCrudAppService<RightRouteTypeDto, int, GetAllRightRouteTypeInputDto>, IRightRouteTypeAppService
    {
        public RightRouteTypeAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public override async Task<ResultDto<RightRouteTypeDto>> Create(RightRouteTypeDto input)
        {
            var result = new ResultDto<RightRouteTypeDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    if (input.Id == default(int))
                        input.Id = Context.NewID<RightRouteType>();
                    var data = ObjectMapper.Map<RightRouteType>(input);
                    Context.RightRouteTypes.Add(data);
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
            return result;
        }

        public override async Task<ResultDto<RightRouteTypeDto>> Update(RightRouteTypeDto input)
        {
            var result = new ResultDto<RightRouteTypeDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    var data = ObjectMapper.Map<RightRouteType>(input);
                    Context.RightRouteTypes.Update(data);
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
            return result;
        }

        public override async Task<ResultDto<RightRouteTypeDto>> Delete(int id)
        {
            var result = new ResultDto<RightRouteTypeDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    var data = await Context.RightRouteTypes.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
                    Context.RightRouteTypes.Remove(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public override async Task<PagedResultDto<RightRouteTypeDto>> GetAll(GetAllRightRouteTypeInputDto input)
        {
            var result = new PagedResultDto<RightRouteTypeDto>();
            try
            {
                var filter = Context.RightRouteTypes.AsNoTracking()
                    .WhereIf(!string.IsNullOrEmpty(input.RightRouteTypeCodeFilter), x => x.RightRouteTypeCode == input.RightRouteTypeCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.RightRouteTypeNameFilter), x => x.RightRouteTypeName == input.RightRouteTypeNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(o => o.SortOrder).PageBy(input).ToList();

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<RightRouteTypeDto>>(paged);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public override async Task<ResultDto<RightRouteTypeDto>> GetById(int id)
        {
            var result = new ResultDto<RightRouteTypeDto>();
            try
            {
                result.Result = ObjectMapper.Map<RightRouteTypeDto>(await Context.RightRouteTypes.FindAsync(id));
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        
    }
}
