using AutoMapper;
using HIS.Dtos.Dictionaries.ItemTypes;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.Core.Application.Services;
using System.Transactions;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Categories.Services;

namespace HIS.ApplicationService.Dictionaries.ItemTypes
{
    public class ItemTypeService : BaseAppService, IItemTypeService
    {
        private readonly IBulkRepository<ItemType, Guid> _itemTypeRepository;
        private readonly IBulkRepository<ItemGroup, Guid> _itemGroupRepository;
        private readonly IBulkRepository<ItemLine, Guid> _itemLineRepository;
        private readonly IBulkRepository<ServiceGroupHeIn, Guid> _serviceGroupHeInRepository;
        private readonly IBulkRepository<Unit, Guid> _unitRepository;

        public ItemTypeService(
            IBulkRepository<ItemType, Guid> itemTypeRepository,
            IBulkRepository<ItemGroup, Guid> itemGroupRepository,
            IBulkRepository<ItemLine, Guid> itemLineRepository,
            IBulkRepository<ServiceGroupHeIn, Guid> serviceGroupHeInRepository,
            IBulkRepository<Unit, Guid> unitRepository)
        {
            _itemTypeRepository = itemTypeRepository;
            _itemGroupRepository = itemGroupRepository;
            _itemLineRepository = itemLineRepository;
            _serviceGroupHeInRepository = serviceGroupHeInRepository;
            _unitRepository = unitRepository;
        }

        public virtual async Task<ResultDto<ItemTypeDto>> CreateOrEdit(ItemTypeDto input)
        {
            var result = await ValidSave(input);
            if (!result.IsSucceeded)
                return result;

            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public virtual async Task<ResultDto<ItemTypeDto>> Create(ItemTypeDto input)
        {
            var result = new ResultDto<ItemTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var ItemType = ObjectMapper.Map<ItemType>(input);
                    ItemType.CreatedDate = DateTime.Now;

                    await _itemTypeRepository.InsertAsync(ItemType); // Context.ItemTypes.Add(ItemType);
                    //await Context.SaveChangesAsync();

                    //result.IsSucceeded = true;
                    //result.Result = input;

                    //transaction.Commit();
                    await unitOfWork.CompleteAsync();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<ItemTypeDto>> Update(ItemTypeDto input)
        {
            var result = new ResultDto<ItemTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var ItemType = ObjectMapper.Map<ItemType>(input);
                    ItemType.ModifiedDate = DateTime.Now;
                    await _itemTypeRepository.UpdateAsync(ItemType);// Context.ItemTypes.Update(ItemType);
                    //await Context.SaveChangesAsync();

                    //result.IsSucceeded = true;
                    //result.Result = input;

                    //transaction.Commit();
                    await unitOfWork.CompleteAsync();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        private async Task<ResultDto<ItemTypeDto>> ValidSave(ItemTypeDto input)
        {
            var result = new ResultDto<ItemTypeDto>();

            try
            {
                List<string> errs = new List<string>();

                #region Ktra để trống

                var emptys = new List<string>();

                if (string.IsNullOrEmpty(input.Code))
                {
                    emptys.Add("Mã thuốc");
                }

                if (string.IsNullOrEmpty(input.HeInCode))
                {
                    emptys.Add("Mã BHYT");
                }

                if (string.IsNullOrEmpty(input.Name))
                {
                    emptys.Add("Tên thuốc");
                }

                if (emptys.Count > 0)
                {
                    errs.Add(string.Format("{0} không được để trống!", string.Join(", ", emptys)));
                }

                #endregion

                var ItemType = _itemTypeRepository.FirstOrDefault(w => w.Code == input.Code && w.Id != input.Id);
                if (ItemType != null)
                {
                    errs.Add(string.Format("Mã thuốc [{0}] đã tồn tại trên hệ thống!", input.Code));
                }

                ItemType = _itemTypeRepository.FirstOrDefault(w => w.HeInCode == input.HeInCode && w.Id != input.Id);
                if (ItemType != null)
                {
                    errs.Add(string.Format("Mã BHYT [{0}] đã tồn tại trên hệ thống!", input.HeInCode));
                }

                if (errs.Count > 0)
                {
                    result.IsSucceeded = false;
                    result.Message = string.Join("\n", errs);
                }
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<ItemTypeDto>> Delete(Guid id)
        {
            var result = new ResultDto<ItemTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _itemTypeRepository.Get(id);

                    await _itemTypeRepository.DeleteAsync(entity);

                    unitOfWork.Complete();
                    result.Success(null);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return await Task.FromResult(result);
        }

        public virtual async Task<PagedResultDto<ItemTypeDto>> GetAll(GetAllItemTypeInput input)
        {
            var result = new PagedResultDto<ItemTypeDto>();
            try
            {
                result.Result = (from medi in _itemTypeRepository.GetAll() 
                                 join unit in _unitRepository.GetAll() on medi.UnitId equals unit.Id into units
                                 from u in units.DefaultIfEmpty()
                                 where medi.IsDeleted == false
                                 select new ItemTypeDto()
                                 {
                                     Id = medi.Id,
                                     CommodityType = medi.CommodityType,
                                     Code = medi.Code,
                                     HeInCode = medi.HeInCode,
                                     Name = medi.Name,
                                     SortOrder = medi.SortOrder,
                                     Description = medi.Description,
                                     Inactive = medi.Inactive,
                                     ItemLineId = medi.ItemLineId, // Đường dùng thuốc
                                     ItemGroupId = medi.ItemGroupId, // Nhóm thuốc
                                     ServiceGroupHeInId = medi.ServiceGroupHeInId, // Nhóm thuốc
                                     UnitId = medi.UnitId, // Đơn vị tính
                                     UnitCode = u.Code, // Đơn vị tính
                                     UnitName = u.Name, // Đơn vị tính
                                     Tutorial = medi.Tutorial, // Hướng dẫn
                                     ActiveSubstance = medi.ActiveSubstance, // Hoạt chất
                                     Concentration = medi.Concentration, // Nồng độ
                                     Content = medi.Content, // Hàm lượng
                                     CountryId = medi.CountryId, // Nước sản xuất
                                     Manufacturer = medi.Manufacturer, // Hãng sản xuất
                                     RegistrationNumber = medi.RegistrationNumber, // Số đăng ký
                                     ProprietaryDrug = medi.ProprietaryDrug, // Biệt dược
                                     PackagingSpecifications = medi.PackagingSpecifications, // Quy cách đóng gói
                                     ImpPrice = medi.ImpPrice, // Giá nhập
                                     ImpVatRate = medi.ImpVatRate, // Phần trăm vat giá nhập
                                     ImpTaxRate = medi.ImpTaxRate, // Phần trăm thuế
                                     IsAntibiotics = medi.IsAntibiotics, // Thuốc kháng sinh
                                     IsNewDrug = medi.IsNewDrug, // Thuốc tân dược
                                     IsPrescriptionDrug = medi.IsPrescriptionDrug, // Thuốc kê đơn
                                     IsNutraceutical = medi.IsNutraceutical, // Dược phẩm chức năng
                                     IsSponsoredDrug = medi.IsSponsoredDrug, // Thuốc Tài trợ
                                     IsInhalantDrug = medi.IsInhalantDrug, // Thuốc khí dung
                                     IsPrescriptionDrugForChildren = medi.IsPrescriptionDrugForChildren, // Thuốc kê đơn trẻ em
                                     IsTraditionalHerbalDrug = medi.IsTraditionalHerbalDrug, // Vị thuốc YHCT
                                     IsTraditionalDrugFormulation = medi.IsTraditionalDrugFormulation, // Chế phẩm YHCT
                                     IsDrugContainerReturnRequest = medi.IsDrugContainerReturnRequest, // YC trả lại vỏ thuốc
                                     IsAllowZeroQuantity = medi.IsAllowZeroQuantity, // Cho phép kê SL bằng 0
                                     IsRadiolabeledDrug = medi.IsRadiolabeledDrug, // Thuốc phóng xạ

                                     // Thông tin khác
                                     PharmaceuticalFormulation = medi.PharmaceuticalFormulation, // Dạng bào chế
                                     Origin = medi.Origin, // Nguồn gốc
                                     ScientificName = medi.ScientificName, // Tên khoa học vị thuốc
                                     ScientificNameChildren = medi.ScientificNameChildren, // Tên KH của cây con, khoáng vật
                                     DugStatus = medi.DugStatus, // Tình trạng dược liệu
                                     RequirementUseDug = medi.RequirementUseDug, // Yêu cầu sử dụng dược liệu
                                     PharmaceuticalDivision = medi.PharmaceuticalDivision, // Bộ phận dược liệu sử dụng
                                     ProcessingLossRate = medi.ProcessingLossRate, // Tỷ lệ hao hụt chế biến
                                     OtherExpenses = medi.OtherExpenses, // Chi phí khác
                                     PreparationMethod = medi.PreparationMethod, // Phương pháp chế biến
                                     QualityStandards = medi.QualityStandards, // Tiêu chuẩn chất lượng
                                 })
                                 .WhereIf(!string.IsNullOrEmpty(input.NameFilter), w => w.Name == input.NameFilter)
                                 .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), w => w.Code == input.CodeFilter)
                                 .WhereIf(input.InactiveFilter != null, w => w.Inactive == input.InactiveFilter)
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(input.ItemLineIdFilter), w => w.ItemLineId == input.ItemLineIdFilter)
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(input.ItemGroupIdFilter), w => w.ItemGroupId == input.ItemGroupIdFilter)
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(input.UnitIdFilter), w => w.UnitId == input.UnitIdFilter)
                                 .WhereIf(input.ItemLineIdsFilter != null && input.ItemLineIdsFilter.Count > 0, w => input.ItemLineIdsFilter.Contains(w.ItemLineId))
                                 .WhereIf(input.ItemGroupIdsFilter != null && input.ItemGroupIdsFilter.Count > 0, w => input.ItemGroupIdsFilter.Contains(w.ItemGroupId))
                                 .WhereIf(input.UnitIdsFilter != null && input.UnitIdsFilter.Count > 0, w => input.UnitIdsFilter.Contains(w.UnitId))
                                 .WhereIf(input.CommodityTypeFilter != null, w => w.CommodityType == (CommodityTypes)input.CommodityTypeFilter)
                                 .OrderBy(o => o.SortOrder).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<ItemTypeDto>> GetById(Guid id)
        {
            var result = new ResultDto<ItemTypeDto>();

            var ItemType = _itemTypeRepository.FirstOrDefault(s => s.Id == id);
            if (ItemType != null)
            {
                result.IsSucceeded = true;
                result.Result = ObjectMapper.Map<ItemTypeDto>(ItemType);
            }

            return await Task.FromResult(result);
        }

        public async Task<ResultDto<bool>> Import(IList<ItemTypeDto> input)
        {
            var result = new ResultDto<bool>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var units = ObjectMapper.Map<List<Unit>>(_unitRepository.GetAllList()).OrderBy(o => o.Code);
                    var itemGroups = ObjectMapper.Map<List<ItemGroup>>(_itemGroupRepository.GetAllList()).OrderBy(o => o.Code);
                    var itemLines = ObjectMapper.Map<List<ItemLine>>(_itemLineRepository.GetAllList()).OrderBy(o => o.Code);
                    var serviceGroupHeIns = ObjectMapper.Map<List<EntityFrameworkCore.Entities.Categories.Services.ServiceGroupHeIn>>(_serviceGroupHeInRepository.GetAllList()).OrderBy(o => o.Code);
                    foreach (var item in input)
                    {
                        //Đơn vị tính
                        if (!string.IsNullOrEmpty(item.UnitCode))
                            item.UnitId = units?.FirstOrDefault(f => f.Code.ToUpper() == item.Code.ToUpper())?.Id;
                        else
                            item.UnitId = units?.FirstOrDefault()?.Id;
                        //Nhóm thuốc
                        if (item.ItemGroupId == null)
                            item.ItemGroupId = itemGroups?.FirstOrDefault()?.Id;
                        //Nhóm bảo hiểm
                        if (item.ServiceGroupHeInId == null)
                            item.ServiceGroupHeInId = serviceGroupHeIns?.FirstOrDefault()?.Id;
                        //Đường dùng
                        if (item.ItemLineId == null)
                            item.ItemLineId = itemLines?.FirstOrDefault()?.Id;
                    }
                    var ItemTypes = ObjectMapper.Map<List<EntityFrameworkCore.Entities.Categories.ItemType>>(input);
                    await _itemTypeRepository.BulkInsertAsync(ItemTypes); // Context.ItemTypes.AddRange(ItemTypes);

                    await unitOfWork.CompleteAsync();
                }
                catch (Exception ex)
                {
                    result.IsSucceeded = false;
                    result.Message = ex.Message;
                }
            }
            return result;
        }
    }
}
