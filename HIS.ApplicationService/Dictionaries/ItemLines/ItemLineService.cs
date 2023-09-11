using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ItemLines;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.ItemLines
{
    public class ItemLineService : BaseSerivce, IItemLineService
    {
        public ItemLineService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
          : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<ItemLineDto>> CreateOrEdit(ItemLineDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        private async Task<ApiResult<ItemLineDto>> Create(ItemLineDto input)
        {
            var result = new ApiResult<ItemLineDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var ItemLine = _mapper.Map<EntityFrameworkCore.Entities.Categories.ItemLine>(input);
                    _dbContext.ItemLines.Add(ItemLine);
                    await _dbContext.SaveChangesAsync();

                    result.IsSuccessed = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        private async Task<ApiResult<ItemLineDto>> Update(ItemLineDto input)
        {
            var result = new ApiResult<ItemLineDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var ItemLine = _mapper.Map<EntityFrameworkCore.Entities.Categories.ItemLine>(input);
                    _dbContext.ItemLines.Update(ItemLine);
                    await _dbContext.SaveChangesAsync();

                    result.IsSuccessed = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public async Task<ApiResult<ItemLineDto>> Delete(Guid id)
        {
            var result = new ApiResult<ItemLineDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var ItemLine = _dbContext.ItemLines.SingleOrDefault(x => x.Id == id);
                    if (ItemLine != null)
                    {
                        _dbContext.ItemLines.Remove(ItemLine);
                        await _dbContext.SaveChangesAsync();
                        result.IsSuccessed = true;

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public async Task<ApiResultList<ItemLineDto>> GetAll(GetAllItemLineInput input)
        {
            var result = new ApiResultList<ItemLineDto>();
            try
            {
                result.Result = (from r in _dbContext.ItemLines
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
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<ItemLineDto>> GetById(Guid id)
        {
            var result = new ApiResult<ItemLineDto>();

            var ItemLine = _dbContext.ItemLines.SingleOrDefault(s => s.Id == id);
            if (ItemLine != null)
            {
                result.Result = _mapper.Map<ItemLineDto>(ItemLine);
            }

            return await Task.FromResult(result);
        }
    }
}
