using HIS.Dtos.Dictionaries.ItemGroups;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Application.Services;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities.Categories;
using System.Transactions;

namespace HIS.ApplicationService.Dictionaries.ItemGroups
{
    public class ItemGroupService : BaseAppService, IItemGroupService
    {
        private readonly IRepository<ItemGroup, Guid> _itemGroupRepository;

        public ItemGroupService(IRepository<ItemGroup, Guid> itemGroupRepository)
        {
            _itemGroupRepository = itemGroupRepository;
        }

        public virtual async Task<ResultDto<ItemGroupDto>> CreateOrEdit(ItemGroupDto input)
        {
            var result = await ValidSave(input);
            if (!result.IsSucceeded)
                return result;

            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public virtual async Task<ResultDto<ItemGroupDto>> Create(ItemGroupDto input)
        {
            var result = new ResultDto<ItemGroupDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<ItemGroup>(input);

                    await _itemGroupRepository.InsertAsync(entity);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<ItemGroupDto>> Update(ItemGroupDto input)
        {
            var result = new ResultDto<ItemGroupDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _itemGroupRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
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

                var ItemGroup = _itemGroupRepository.FirstOrDefault(w => w.Code == input.Code && w.Id != input.Id);
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

        public virtual async Task<ResultDto<ItemGroupDto>> Delete(Guid id)
        {
            var result = new ResultDto<ItemGroupDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _itemGroupRepository.Get(id);

                    await _itemGroupRepository.DeleteAsync(entity);

                    unitOfWork.Complete();
                    result.Success(null);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<PagedResultDto<ItemGroupDto>> GetAll(GetAllItemGroupInput input)
        {
            var result = new PagedResultDto<ItemGroupDto>();
            try
            {
                result.IsSucceeded = true;
                result.Result = (from r in _itemGroupRepository.GetAll()

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

        public virtual async Task<ResultDto<ItemGroupDto>> GetById(Guid id)
        {
            var result = new ResultDto<ItemGroupDto>();

            var ItemGroup = _itemGroupRepository.FirstOrDefault(s => s.Id == id);
            if (ItemGroup != null)
            {
                result.IsSucceeded = true;
                result.Result = ObjectMapper.Map<ItemGroupDto>(ItemGroup);
            }

            return await Task.FromResult(result);
        }
    }
}
