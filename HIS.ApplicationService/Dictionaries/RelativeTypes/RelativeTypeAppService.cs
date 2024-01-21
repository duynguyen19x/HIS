using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Services.Dto;
using HIS.Core.Linq.Extensions;
using HIS.Dtos.Dictionaries.RelativeTypes;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.RelativeTypes
{
    public class RelativeTypeAppService : BaseCrudAppService<RelativeTypeDto, Guid, GetAllRelativeTypeInputDto>, IRelativeTypeAppService
    {
        public RelativeTypeAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public override async Task<ResultDto<RelativeTypeDto>> Create(RelativeTypeDto input)
        {
            var result = new ResultDto<RelativeTypeDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<RelativeType>(input);
                    Context.RelativeTypes.Add(data);
                    await Context.SaveChangesAsync();

                    result.Result = input;
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

        public override async Task<ResultDto<RelativeTypeDto>> Update(RelativeTypeDto input)
        {
            var result = new ResultDto<RelativeTypeDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    var data = ObjectMapper.Map<RelativeType>(input);
                    Context.RelativeTypes.Update(data);
                    await Context.SaveChangesAsync();

                    result.Result = input;
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

        public override async Task<ResultDto<RelativeTypeDto>> Delete(Guid id)
        {
            var result = new ResultDto<RelativeTypeDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    var data = Context.Genders.SingleOrDefault(x => x.Id == id);
                    if (data != null)
                    {
                        Context.Genders.Remove(data);
                        await Context.SaveChangesAsync();

                        result.IsSucceeded = true;
                        result.Result = ObjectMapper.Map<RelativeTypeDto>(data);    

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
            return result;
        }

        public override async Task<PagedResultDto<RelativeTypeDto>> GetAll(GetAllRelativeTypeInputDto input)
        {
            var result = new PagedResultDto<RelativeTypeDto>();
            try
            {
                var filter = Context.RelativeTypes.AsNoTracking()
                    .WhereIf(!string.IsNullOrEmpty(input.RelativeTypeCodeFilter), x => x.RelativeTypeCode == input.RelativeTypeCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.RelativeTypeNameFilter), x => x.RelativeTypeName == input.RelativeTypeNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(o => o.SortOrder).PageBy(input);
                var data = paged.ToList();

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<RelativeTypeDto>>(data);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public override async Task<ResultDto<RelativeTypeDto>> GetById(Guid id)
        {
            var result = new ResultDto<RelativeTypeDto>();
            try
            {
                var data = await Context.RelativeTypes.FindAsync(id);
                result.Result = ObjectMapper.Map<RelativeTypeDto>(data);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        
    }
}
