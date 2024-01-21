using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Services.Dto;
using HIS.Core.Linq.Extensions;
using HIS.Dtos.Dictionaries.ItemGroups;
using HIS.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.ItemGroups
{
    public class ItemGroupService : BaseCrudAppService<ItemGroupDto, Guid?, GetAllItemGroupInput>, IItemGroupService
    {
        public ItemGroupService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
           : base(dbContext, mapper)
        {
        }

        public override async Task<ResultDto<ItemGroupDto>> CreateOrEdit(ItemGroupDto input)
        {
            var result = await ValidSave(input);
            if (!result.IsSucceeded)
                return result;

            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public override async Task<ResultDto<ItemGroupDto>> Create(ItemGroupDto input)
        {
            var result = new ResultDto<ItemGroupDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var ItemGroup = ObjectMapper.Map<EntityFrameworkCore.Entities.Categories.ItemGroup>(input);
                    Context.ItemGroups.Add(ItemGroup);
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

        public override async Task<ResultDto<ItemGroupDto>> Update(ItemGroupDto input)
        {
            var result = new ResultDto<ItemGroupDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var ItemGroup = ObjectMapper.Map<EntityFrameworkCore.Entities.Categories.ItemGroup>(input);
                    Context.ItemGroups.Update(ItemGroup);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Result = input;

                    transaction.Commit();
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

        private async Task<ResultDto<ItemGroupDto>> ValidSave(ItemGroupDto input)
        {
            var result = new ResultDto<ItemGroupDto>();

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

                var ItemGroup = Context.ItemGroups.FirstOrDefault(w => w.Code == input.Code && w.Id != input.Id);
                if (ItemGroup != null)
                {
                    errs.Add(string.Format("Mã nhóm thuốc [{0}] đã tồn tại trên hệ thống!", input.Code));
                }

                if (errs.Count > 0)
                {
                    result.IsSucceeded = false;
                    result.Message = string.Join("\n", errs);
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<ItemGroupDto>> Delete(Guid? id)
        {
            var result = new ResultDto<ItemGroupDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var ItemGroup = Context.ItemGroups.SingleOrDefault(x => x.Id == id);
                    if (ItemGroup != null)
                    {
                        Context.ItemGroups.Remove(ItemGroup);
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

        public override async Task<PagedResultDto<ItemGroupDto>> GetAll(GetAllItemGroupInput input)
        {
            var result = new PagedResultDto<ItemGroupDto>();
            try
            {
                result.IsSucceeded = true;
                result.Result = (from r in Context.ItemGroups

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
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<ItemGroupDto>> GetById(Guid? id)
        {
            var result = new ResultDto<ItemGroupDto>();

            var ItemGroup = Context.ItemGroups.SingleOrDefault(s => s.Id == id);
            if (ItemGroup != null)
            {
                result.IsSucceeded = true;
                result.Result = ObjectMapper.Map<ItemGroupDto>(ItemGroup);
            }

            return await Task.FromResult(result);
        }
    }
}
