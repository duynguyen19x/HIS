using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ItemTypes;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.ItemTypes
{
    public class ItemTypeService : BaseSerivce, IItemTypeService
    {
        public ItemTypeService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
           : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<ItemTypeDto>> CreateOrEdit(ItemTypeDto input)
        {
            var result = await ValidSave(input);
            if (!result.IsSuccessed)
                return result;

            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<ItemTypeDto>> Create(ItemTypeDto input)
        {
            var result = new ApiResult<ItemTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var ItemType = _mapper.Map<EntityFrameworkCore.Entities.Categories.ItemType>(input);
                    ItemType.CreatedDate = DateTime.Now;

                    _dbContext.ItemTypes.Add(ItemType);
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

        public async Task<ApiResult<ItemTypeDto>> Update(ItemTypeDto input)
        {
            var result = new ApiResult<ItemTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var ItemType = _mapper.Map<EntityFrameworkCore.Entities.Categories.ItemType>(input);
                    ItemType.ModifiedDate = DateTime.Now;
                    _dbContext.ItemTypes.Update(ItemType);
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

        private async Task<ApiResult<ItemTypeDto>> ValidSave(ItemTypeDto input)
        {
            var result = new ApiResult<ItemTypeDto>();

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

                var ItemType = _dbContext.ItemTypes.FirstOrDefault(w => w.Code == input.Code && w.Id != input.Id);
                if (ItemType != null)
                {
                    errs.Add(string.Format("Mã thuốc [{0}] đã tồn tại trên hệ thống!", input.Code));
                }

                ItemType = _dbContext.ItemTypes.FirstOrDefault(w => w.HeInCode == input.HeInCode && w.Id != input.Id);
                if (ItemType != null)
                {
                    errs.Add(string.Format("Mã BHYT [{0}] đã tồn tại trên hệ thống!", input.HeInCode));
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

        public async Task<ApiResult<ItemTypeDto>> Delete(Guid id)
        {
            var result = new ApiResult<ItemTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var ItemType = _dbContext.ItemTypes.SingleOrDefault(x => x.Id == id);
                    if (ItemType != null)
                    {
                        ItemType.IsDeleted = true;
                        ItemType.DeletedDate = DateTime.Now;

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

        public async Task<ApiResultList<ItemTypeDto>> GetAll(GetAllItemTypeInput input)
        {
            var result = new ApiResultList<ItemTypeDto>();
            try
            {
                result.Result = (from medi in _dbContext.ItemTypes
                                 join unit in _dbContext.Units on medi.UnitId equals unit.Id
                                 where medi.IsDeleted == false
                                 select new ItemTypeDto()
                                 {
                                     Id = medi.Id,
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
                                     UnitCode = unit.Code, // Đơn vị tính
                                     UnitName = unit.Name, // Đơn vị tính
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

        public async Task<ApiResult<ItemTypeDto>> GetById(Guid id)
        {
            var result = new ApiResult<ItemTypeDto>();

            var ItemType = _dbContext.ItemTypes.SingleOrDefault(s => s.Id == id);
            if (ItemType != null)
            {
                result.IsSuccessed = true;
                result.Result = _mapper.Map<ItemTypeDto>(ItemType);
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<bool>> Import(IList<ItemTypeDto> input)
        {
            var result = new ApiResult<bool>();

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var ItemTypes = _mapper.Map<List<EntityFrameworkCore.Entities.Categories.ItemType>>(input);
                    _dbContext.ItemTypes.AddRange(ItemTypes);
                    await _dbContext.SaveChangesAsync();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                    transaction.Rollback();
                }
            }
            return await Task.FromResult(result);
        }
    }
}
