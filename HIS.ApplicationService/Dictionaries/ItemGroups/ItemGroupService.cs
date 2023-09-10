using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ItemGroups;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.ItemGroups
{
    public class ItemGroupService : BaseSerivce, IItemGroupService
    {
        public ItemGroupService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
           : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<ItemGroupDto>> CreateOrEdit(ItemGroupDto input)
        {
            var result = await ValidSave(input);
            if (!result.IsSuccessed)
                return result;

            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<ItemGroupDto>> Create(ItemGroupDto input)
        {
            var result = new ApiResult<ItemGroupDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var ItemGroup = _mapper.Map<EntityFrameworkCore.Entities.Categories.ItemGroup>(input);
                    _dbContext.ItemGroups.Add(ItemGroup);
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

        public async Task<ApiResult<ItemGroupDto>> Update(ItemGroupDto input)
        {
            var result = new ApiResult<ItemGroupDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var ItemGroup = _mapper.Map<EntityFrameworkCore.Entities.Categories.ItemGroup>(input);
                    _dbContext.ItemGroups.Update(ItemGroup);
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

        private async Task<ApiResult<ItemGroupDto>> ValidSave(ItemGroupDto input)
        {
            var result = new ApiResult<ItemGroupDto>();

            try
            {
                List<string> errs = new List<string>();

                #region Ktra để trống

                var emptys = new List<string>();

                if (string.IsNullOrEmpty(input.Code))
                {
                    emptys.Add("Mã nhóm thuốc");
                }

                if (string.IsNullOrEmpty(input.Name))
                {
                    emptys.Add("Tên nhóm thuốc");
                }

                if (emptys.Count > 0)
                {
                    errs.Add(string.Format("{0} không được để trống!", string.Join(", ", emptys)));
                }

                #endregion

                var ItemGroup = _dbContext.ItemGroups.FirstOrDefault(w => w.Code == input.Code && w.Id != input.Id);
                if (ItemGroup != null)
                {
                    errs.Add(string.Format("Mã nhóm thuốc [{0}] đã tồn tại trên hệ thống!", input.Code));
                }

                if (errs.Count > 0)
                {
                    result.IsSuccessed = false;
                    result.Message = string.Join("\n", errs);
                }
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<ItemGroupDto>> Delete(Guid id)
        {
            var result = new ApiResult<ItemGroupDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var ItemGroup = _dbContext.ItemGroups.SingleOrDefault(x => x.Id == id);
                    if (ItemGroup != null)
                    {
                        _dbContext.ItemGroups.Remove(ItemGroup);
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

        public async Task<ApiResultList<ItemGroupDto>> GetAll(GetAllItemGroupInput input)
        {
            var result = new ApiResultList<ItemGroupDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.ItemGroups

                                 select new ItemGroupDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     SortOrder = r.SortOrder,
                                     IsSystem = r.IsSystem,
                                     CommodityType = r.CommodityType,
                                     Inactive = r.Inactive
                                 })
                                 .WhereIf(!string.IsNullOrEmpty(input.NameFilter), r => r.Name == input.NameFilter)
                                 .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), r => r.Code == input.CodeFilter)
                                 .WhereIf(input.InactiveFilter != null, r => r.Inactive == input.InactiveFilter)
                                 .WhereIf(input.CommodityTypeFilter != null, r => r.CommodityType == input.CommodityTypeFilter)
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

        public async Task<ApiResult<ItemGroupDto>> GetById(Guid id)
        {
            var result = new ApiResult<ItemGroupDto>();

            var ItemGroup = _dbContext.ItemGroups.SingleOrDefault(s => s.Id == id);
            if (ItemGroup != null)
            {
                result.IsSuccessed = true;
                result.Result = _mapper.Map<ItemGroupDto>(ItemGroup);
            }

            return await Task.FromResult(result);
        }
    }
}
