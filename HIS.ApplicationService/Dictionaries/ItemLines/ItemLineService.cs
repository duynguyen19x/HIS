using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.ItemLines;
using HIS.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.ItemLines
{
    public class ItemLineService : BaseCrudAppService<ItemLineDto, Guid?, GetAllItemLineInput>, IItemLineService
    {
        public ItemLineService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
          : base(dbContext, mapper)
        {

        }

        public override async Task<ResultDto<ItemLineDto>> Create(ItemLineDto input)
        {
            var result = new ResultDto<ItemLineDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var ItemLine = ObjectMapper.Map<EntityFrameworkCore.Entities.Categories.ItemLine>(input);
                    Context.ItemLines.Add(ItemLine);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Result = input;

                    transaction.Commit();
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

        public override async Task<ResultDto<ItemLineDto>> Update(ItemLineDto input)
        {
            var result = new ResultDto<ItemLineDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var ItemLine = ObjectMapper.Map<EntityFrameworkCore.Entities.Categories.ItemLine>(input);
                    Context.ItemLines.Update(ItemLine);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Result = input;

                    transaction.Commit();
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

        public override async Task<ResultDto<ItemLineDto>> Delete(Guid? id)
        {
            var result = new ResultDto<ItemLineDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var ItemLine = Context.ItemLines.SingleOrDefault(x => x.Id == id);
                    if (ItemLine != null)
                    {
                        Context.ItemLines.Remove(ItemLine);
                        await Context.SaveChangesAsync();
                        result.IsSucceeded = true;

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.IsSucceeded = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<PagedResultDto<ItemLineDto>> GetAll(GetAllItemLineInput input)
        {
            var result = new PagedResultDto<ItemLineDto>();
            try
            {
                result.Result = (from r in Context.ItemLines
                                 select new ItemLineDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Inactive = r.Inactive,
                                     SortOrder = r.SortOrder
                                 })
                                 .WhereIf(!string.IsNullOrEmpty(input.NameFilter), r => r.Name == input.NameFilter)
                                 .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), r => r.Code == input.CodeFilter)
                                 .WhereIf(input.InactiveFilter != null, r => r.Inactive == input.InactiveFilter)
                                 .OrderBy(o => o.SortOrder).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<ItemLineDto>> GetById(Guid? id)
        {
            var result = new ResultDto<ItemLineDto>();

            var ItemLine = Context.ItemLines.SingleOrDefault(s => s.Id == id);
            if (ItemLine != null)
            {
                result.Result = ObjectMapper.Map<ItemLineDto>(ItemLine);
            }

            return await Task.FromResult(result);
        }
    }
}
