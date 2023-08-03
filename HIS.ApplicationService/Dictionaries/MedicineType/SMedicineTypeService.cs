using AutoMapper;
using HIS.ApplicationService.Dictionaries.MedicineGroup;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicineGroup;
using HIS.Dtos.Dictionaries.MedicineType;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

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

                if (string.IsNullOrEmpty(input.Code))
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
                        medicineType.IsDelete = true;
                        medicineType.DeleteDate = DateTime.Now;

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
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SMedicineTypes
                                 where r.IsDelete == false
                                 select new SMedicineTypeDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     HeInCode = r.HeInCode,
                                     Name = r.Name,
                                     SortOrder = r.SortOrder,
                                     Description = r.Description,
                                     Inactive = r.Inactive,
                                     MedicineLineId = r.MedicineLineId, //Đường dùng thuốc
                                     MedicineGroupId = r.MedicineGroupId, // Nhóm thuốc
                                     ServiceGroupHeInId = r.ServiceGroupHeInId, // Nhóm thuốc
                                     UnitId = r.UnitId, // Đơn vị tính
                                     Tutorial = r.Tutorial, // Hướng dẫn
                                     ActiveSubstance = r.ActiveSubstance, // Hoạt chất
                                     Concentration = r.Concentration, // Nồng độ
                                     Content = r.Content, // Hàm lượng
                                     CountryId = r.CountryId, // Nước sản xuất
                                     Manufacturer = r.Manufacturer, // Hãng sản xuất
                                     RegistrationNumber = r.RegistrationNumber, // Số đăng ký
                                     ProprietaryDrug = r.ProprietaryDrug, // Biệt dược
                                     PackagingSpecifications = r.PackagingSpecifications, // Quy cách đóng gói
                                     ImpPrice = r.ImpPrice, // Giá nhập
                                     ImpVatRate = r.ImpVatRate, // Phần trăm vat giá nhập
                                     TaxRate = r.TaxRate, // Phần trăm thuế
                                     IsAntibiotics = r.IsAntibiotics, // Thuốc kháng sinh
                                     IsNewDrug = r.IsNewDrug, // Thuốc tân dược
                                     IsPrescriptionDrug = r.IsPrescriptionDrug, // Thuốc kê đơn
                                     IsNutraceutical = r.IsNutraceutical, // Dược phẩm chức năng
                                     IsSponsoredDrug = r.IsSponsoredDrug, // Thuốc Tài trợ
                                     IsInhalantDrug = r.IsInhalantDrug, // Thuốc khí dung
                                     IsPrescriptionDrugForChildren = r.IsPrescriptionDrugForChildren, // Thuốc kê đơn trẻ em
                                     IsTraditionalHerbalDrug = r.IsTraditionalHerbalDrug, // Vị thuốc YHCT
                                     IsTraditionalDrugFormulation = r.IsTraditionalDrugFormulation, // Chế phẩm YHCT
                                     IsDrugContainerReturnRequest = r.IsDrugContainerReturnRequest, // YC trả lại vỏ thuốc
                                     IsAllowZeroQuantity = r.IsAllowZeroQuantity, // Cho phép kê SL bằng 0
                                     IsRadiolabeledDrug = r.IsRadiolabeledDrug, // Thuốc phóng xạ

                                     // Thông tin khác
                                     PharmaceuticalFormulation = r.PharmaceuticalFormulation, // Dạng bào chế
                                     Origin = r.Origin, // Nguồn gốc
                                     ScientificName = r.ScientificName, // Tên khoa học vị thuốc
                                     ScientificNameChildren = r.ScientificNameChildren, // Tên KH của cây con, khoáng vật
                                     DugStatus = r.DugStatus, // Tình trạng dược liệu
                                     RequirementUseDug = r.RequirementUseDug, // Yêu cầu sử dụng dược liệu
                                     PharmaceuticalDivision = r.PharmaceuticalDivision, // Bộ phận dược liệu sử dụng
                                     ProcessingLossRate = r.ProcessingLossRate, // Tỷ lệ hao hụt chế biến
                                     OtherExpenses = r.OtherExpenses, // Chi phí khác
                                     PreparationMethod = r.PreparationMethod, // Phương pháp chế biến
                                     QualityStandards = r.QualityStandards, // Tiêu chuẩn chất lượng
                                 }).WhereIf(!string.IsNullOrEmpty(input.NameFilter), w => w.Name == input.NameFilter)
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
