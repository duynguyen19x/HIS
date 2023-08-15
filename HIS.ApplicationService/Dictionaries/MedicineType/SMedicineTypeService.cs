using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicineType;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.MedicineType
{
    public class SMedicineTypeService : BaseSerivce, ISMedicineTypeService
    {
        public SMedicineTypeService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
           : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<SMedicineTypeDto>> CreateOrEdit(SMedicineTypeDto input)
        {
            var result = await ValidSave(input);
            if (!result.IsSuccessed)
                return result;

            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SMedicineTypeDto>> Create(SMedicineTypeDto input)
        {
            var result = new ApiResult<SMedicineTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var medicineType = _mapper.Map<SMedicineType>(input);
                    medicineType.CreatedDate = DateTime.Now;

                    _dbContext.SMedicineTypes.Add(medicineType);
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

        public async Task<ApiResult<SMedicineTypeDto>> Update(SMedicineTypeDto input)
        {
            var result = new ApiResult<SMedicineTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var medicineType = _mapper.Map<SMedicineType>(input);
                    medicineType.ModifiedDate = DateTime.Now;
                    _dbContext.SMedicineTypes.Update(medicineType);
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

        private async Task<ApiResult<SMedicineTypeDto>> ValidSave(SMedicineTypeDto input)
        {
            var result = new ApiResult<SMedicineTypeDto>();

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

                var medicineType = _dbContext.SMedicineTypes.FirstOrDefault(w => w.Code == input.Code && w.Id != input.Id);
                if (medicineType != null)
                {
                    errs.Add(string.Format("Mã thuốc [{0}] đã tồn tại trên hệ thống!", input.Code));
                }

                medicineType = _dbContext.SMedicineTypes.FirstOrDefault(w => w.HeInCode == input.HeInCode && w.Id != input.Id);
                if (medicineType != null)
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

        public async Task<ApiResult<SMedicineTypeDto>> Delete(Guid id)
        {
            var result = new ApiResult<SMedicineTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var medicineType = _dbContext.SMedicineTypes.SingleOrDefault(x => x.Id == id);
                    if (medicineType != null)
                    {
                        medicineType.IsDeleted = true;
                        medicineType.DeletedDate = DateTime.Now;

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

        public async Task<ApiResultList<SMedicineTypeDto>> GetAll(GetAllSMedicineTypeInput input)
        {
            var result = new ApiResultList<SMedicineTypeDto>();
            try
            {
                result.Result = (from medi in _dbContext.SMedicineTypes
                                 join unit in _dbContext.SUnits on medi.UnitId equals unit.Id
                                 where medi.IsDeleted == false
                                 select new SMedicineTypeDto()
                                 {
                                     Id = medi.Id,
                                     Code = medi.Code,
                                     HeInCode = medi.HeInCode,
                                     Name = medi.Name,
                                     SortOrder = medi.SortOrder,
                                     Description = medi.Description,
                                     Inactive = medi.Inactive,
                                     MedicineLineId = medi.MedicineLineId, // Đường dùng thuốc
                                     MedicineGroupId = medi.MedicineGroupId, // Nhóm thuốc
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
                                     TaxRate = medi.TaxRate, // Phần trăm thuế
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
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(input.MedicineLineIdFilter), w => w.MedicineLineId == input.MedicineLineIdFilter)
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(input.MedicineGroupIdFilter), w => w.MedicineGroupId == input.MedicineGroupIdFilter)
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(input.UnitIdFilter), w => w.UnitId == input.UnitIdFilter)
                                 .WhereIf(input.MedicineLineIdsFilter != null && input.MedicineLineIdsFilter.Count > 0, w => input.MedicineLineIdsFilter.Contains(w.MedicineLineId))
                                 .WhereIf(input.MedicineGroupIdsFilter != null && input.MedicineGroupIdsFilter.Count > 0, w => input.MedicineGroupIdsFilter.Contains(w.MedicineGroupId))
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

        public async Task<ApiResult<SMedicineTypeDto>> GetById(Guid id)
        {
            var result = new ApiResult<SMedicineTypeDto>();

            var medicineType = _dbContext.SMedicineTypes.SingleOrDefault(s => s.Id == id);
            if (medicineType != null)
            {
                result.IsSuccessed = true;
                result.Result = _mapper.Map<SMedicineTypeDto>(medicineType);
            }

            return await Task.FromResult(result);
        }
    }
}
