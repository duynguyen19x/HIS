using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.RelativeTypes;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.RelativeTypes
{
    public class RelativeTypeAppService : BaseCrudAppService<RelativeTypeDto, Guid, PagedRelativeTypeInputDto>, IRelativeTypeAppService
    {
        public RelativeTypeAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<RelativeTypeDto>> Create(RelativeTypeDto input)
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

                    result.IsSucceeded = true;
                    result.Item = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async override Task<ResultDto<RelativeTypeDto>> Update(RelativeTypeDto input)
        {
            var result = new ResultDto<RelativeTypeDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    var relativeType = Context.RelativeTypes.FirstOrDefault(f => f.Id == input.Id);
                    if (relativeType != null)
                        ObjectMapper.Map(input, relativeType);

                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Item = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async override Task<ResultDto<RelativeTypeDto>> Delete(Guid id)
        {
            var result = new ResultDto<RelativeTypeDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    var relativeType = Context.RelativeTypes.SingleOrDefault(x => x.Id == id);
                    if (relativeType != null)
                    {
                        Context.RelativeTypes.Remove(relativeType);
                        await Context.SaveChangesAsync();

                        result.IsSucceeded = true;

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }

            return result;
        }

        public override async Task<PagedResultDto<RelativeTypeDto>> GetAll(PagedRelativeTypeInputDto input)
        {
            var result = new PagedResultDto<RelativeTypeDto>();
            var relativeTypes = Context.RelativeTypes
                .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter)
                .OrderBy(o => o.SortOrder);

            result.TotalCount = await relativeTypes.CountAsync();
            result.Items = ObjectMapper.Map<IList<RelativeTypeDto>>(relativeTypes.ToList());

            return result;
        }

        public async override Task<ResultDto<RelativeTypeDto>> GetById(Guid id)
        {
            var result = new ResultDto<RelativeTypeDto>();
            try
            {
                var relativeType = await Context.RelativeTypes.FirstOrDefaultAsync(s => s.Id == id);
                result.Item = ObjectMapper.Map<RelativeTypeDto>(relativeType);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return result;
        }

        
    }
}
