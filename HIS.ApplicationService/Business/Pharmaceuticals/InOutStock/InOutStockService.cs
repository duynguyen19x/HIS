using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicinePricePolicy;
using HIS.EntityFrameworkCore.Entities.Categories.Medicines;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using HIS.Utilities.Sections;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Dtos.Business.InOutStock;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals;
using HIS.Core.Linq;
using HIS.Dtos.Business.InOutStockMedicine;

namespace HIS.ApplicationService.Business.Pharmaceuticals.InOutStock
{
    public class InOutStockService : BaseSerivce, IInOutStockService
    {
        public InOutStockService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper) { }

        public async Task<ApiResultList<InOutStockDto>> GetByStocks(Guid stockId, string fromDate, string toDate)
        {
            var result = new ApiResultList<InOutStockDto>();

            try
            {
                DateTime fromDateTime = DateTime.ParseExact(fromDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);
                DateTime toDateTime = DateTime.ParseExact(toDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);

                result.Result = (from inOutStock in _dbContext.InOutStocks

                                 join imStock in _dbContext.Rooms on inOutStock.ImpStockId equals imStock.Id into imStockDefaults
                                 from imStockDefault in imStockDefaults.DefaultIfEmpty()

                                 join exStock in _dbContext.Rooms on inOutStock.ExpStockId equals exStock.Id into exStockDefaults
                                 from exStockDefault in exStockDefaults.DefaultIfEmpty()

                                 join inOutStockType in _dbContext.InOutStockTypes on inOutStock.InOutStockTypeId equals inOutStockType.Id into inOutStockTypeDefaults
                                 from inOutStockTypeDefault in inOutStockTypeDefaults.DefaultIfEmpty()

                                 select new InOutStockDto()
                                 {
                                     Id = inOutStock.Id,
                                     Code = inOutStock.Code,
                                     Type = inOutStock.Type,
                                     Status = inOutStock.Status,
                                     ImpStockId = inOutStock.ImpStockId,
                                     ImpStockCode = imStockDefault != null ? imStockDefault.Code : null,
                                     ImpStockName = imStockDefault != null ? imStockDefault.Name : null,
                                     ExpStockId = inOutStock.ExpStockId,
                                     ExpStockCode = exStockDefault != null ? exStockDefault.Code : null,
                                     ExpStockName = exStockDefault != null ? exStockDefault.Name : null,
                                     InOutStockTypeId = inOutStock.InOutStockTypeId,
                                     InOutStockTypeName = inOutStockTypeDefault != null ? inOutStockTypeDefault.Name : null,
                                     ReceiverUserId = inOutStock.ReceiverUserId,
                                     ApproverUserId = inOutStock.ApproverUserId,
                                     ReqTime = inOutStock.ReqTime,
                                     CreationUserId = inOutStock.CreationUserId,
                                     StockImpUserId = inOutStock.StockImpUserId,
                                     StockImpTime = inOutStock.StockImpTime,
                                     ApproverTime = inOutStock.ApproverTime,
                                     Description = inOutStock.Description,
                                     ReqRoomId = inOutStock.ReqRoomId,
                                     ReqDepartmentId = inOutStock.ReqDepartmentId,
                                     PatientRecordId = inOutStock.PatientRecordId,
                                     PatientId = inOutStock.PatientId,
                                     SupplierId = inOutStock.SupplierId,
                                     InvTime = inOutStock.InvTime,
                                     InvNo = inOutStock.InvNo,
                                     Deliverer = inOutStock.Deliverer,
                                     StockExpTime = inOutStock.StockExpTime,
                                     StockExpUserId = inOutStock.StockExpUserId,
                                 })
                                 .WhereIf(fromDateTime != (DateTime)default, w => w.ReqTime >= fromDateTime)
                                 .WhereIf(toDateTime != (DateTime)default, w => w.ReqTime <= toDateTime)
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(stockId), w => w.ImpStockId == stockId)
                                 .ToList();
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }


            return await Task.FromResult(result);
        }

        #region Nhập từ nhà cung cấp
        /// <summary>
        /// Lấy phiếu nhập NCC
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromSupplierGetById(Guid id)
        {
            var result = new ApiResult<InOutStockDto>();

            try
            {
                var inOutStockDto = _mapper.Map<InOutStockDto>(_dbContext.InOutStocks.FirstOrDefault(d => d.Id == id));
                if (inOutStockDto != null)
                {
                    // Nhập thuốc NCC
                    if (inOutStockDto.InOutStockTypeId == 1)
                    {
                        var inOutStockMedicineDtos = _mapper.Map<IList<InOutStockMedicineDto>>(_dbContext.InOutStockMedicines.Where(w => w.InOutStockId == id).ToList());
                        var medicineIds = inOutStockMedicineDtos.Select(s => s.MedicineId).ToList();
                        var medicineDtos = _mapper.Map<IList<Medicine>>(_dbContext.Medicines.Where(w => medicineIds.Contains(w.Id)).ToList());

                        var medicinePricePolicyDtos = (from med in _dbContext.MedicinePricePolicies
                                                       join pa in _dbContext.PatientTypes on med.PatientTypeId equals pa.Id
                                                       select new MedicinePricePolicyDto()
                                                       {
                                                           Id = med.Id,
                                                           MedicineId = med.MedicineId,
                                                           PatientTypeId = med.PatientTypeId,
                                                           OldUnitPrice = med.OldUnitPrice,
                                                           NewUnitPrice = med.NewUnitPrice,
                                                           CeilingPrice = med.CeilingPrice,
                                                           PaymentRate = med.PaymentRate,
                                                           ExecutionTime = med.ExecutionTime,
                                                           PatientTypeCode = pa.Code,
                                                           PatientTypeName = pa.Name,
                                                           IsHeIn = pa.Code == PatientTypes.BHYT ? true : false,
                                                       })
                                                      .WhereIf(medicineIds != null, w => medicineIds.Contains(w.MedicineId))
                                                      .OrderBy(s => s.PatientTypeCode).ToList();

                        foreach (var inOutStockMedicine in inOutStockMedicineDtos)
                        {
                            var sMedicine = medicineDtos.FirstOrDefault(f => f.Id == inOutStockMedicine.MedicineId);

                            if (!string.IsNullOrEmpty(sMedicine.Code))
                                inOutStockMedicine.Code = sMedicine.Code.Split('.')?[0];

                            inOutStockMedicine.HeInCode = sMedicine.HeInCode;
                            inOutStockMedicine.Name = sMedicine.Name;
                            inOutStockMedicine.SortOrder = sMedicine.SortOrder;
                            inOutStockMedicine.MedicineLineId = sMedicine.MedicineLineId;
                            inOutStockMedicine.MedicineGroupId = sMedicine.MedicineGroupId;
                            inOutStockMedicine.MedicineTypeId = sMedicine.MedicineTypeId;
                            inOutStockMedicine.UnitId = sMedicine.UnitId;
                            inOutStockMedicine.Tutorial = sMedicine.Tutorial;
                            inOutStockMedicine.CountryId = sMedicine.CountryId;
                            inOutStockMedicine.ImpPrice = sMedicine.ImpPrice;
                            inOutStockMedicine.ImpVatRate = sMedicine.ImpVatRate;
                            inOutStockMedicine.TaxRate = sMedicine.TaxRate;
                            inOutStockMedicine.Description = sMedicine.Description;
                            inOutStockMedicine.ActiveSubstance = sMedicine.ActiveSubstance;
                            inOutStockMedicine.Concentration = sMedicine.Concentration;
                            inOutStockMedicine.Content = sMedicine.Content;
                            inOutStockMedicine.Manufacturer = sMedicine.Manufacturer;
                            inOutStockMedicine.PackagingSpecifications = sMedicine.PackagingSpecifications;
                            inOutStockMedicine.Dosage = sMedicine.Dosage;
                            inOutStockMedicine.Lot = sMedicine.Lot;
                            inOutStockMedicine.DueDate = sMedicine.DueDate;
                            inOutStockMedicine.TenderDecision = sMedicine.TenderDecision;
                            inOutStockMedicine.TenderPackage = sMedicine.TenderPackage;
                            inOutStockMedicine.TenderGroup = sMedicine.TenderGroup;
                            inOutStockMedicine.TenderYear = sMedicine.TenderYear;

                            inOutStockMedicine.MedicinePricePolicies = medicinePricePolicyDtos.Where(w => w.MedicineId == inOutStockMedicine.MedicineId).ToList();
                        }

                        inOutStockDto.InOutStockMedicines = inOutStockMedicineDtos;
                    }
                }

                result.Result = inOutStockDto;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Hủy nhập kho
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ApiResult<bool>> ImportFromSupplierCanceled(Guid id)
        {
            var result = new ApiResult<bool>();

            try
            {
                var timeNow = DateTime.Now;

                var dImpMests = _dbContext.InOutStocks.FirstOrDefault(w => w.Id == id);

                // Nhập thuốc từ nhà cung cấp
                if (dImpMests.InOutStockTypeId == 1)
                {
                    var medicineOlds = (from inOutStock in _dbContext.InOutStocks
                                        join inOutStockMedicine in _dbContext.InOutStockMedicines on inOutStock.Id equals inOutStockMedicine.InOutStockId
                                        where inOutStock.Id == id && inOutStock.IsDeleted == false
                                        select new
                                        {
                                            inOutStockMedicine.Id,
                                            inOutStockMedicine.MedicineId,
                                            inOutStockMedicine.RequestQuantity,
                                            inOutStockMedicine.ApprovedQuantity,
                                            inOutStock.ImpStockId,
                                            inOutStock.InOutStockTypeId,
                                        }).Distinct().ToList();


                    if (medicineOlds != null && medicineOlds.Count > 0)
                    {
                        var stockId = medicineOlds.Select(s => s.ImpStockId).Distinct().ToList();
                        var medicinIds = medicineOlds.Select(s => s.MedicineId).Distinct().ToList();
                        var sMedicineStocks = _dbContext.MedicineStocks.Where(w => stockId.Contains(w.StockId) && medicinIds.Contains(w.MedicineId)).ToList();

                        // Ktra số lượng đã bị xuất nhập chưa để hủy phiếu
                        bool anyExists = sMedicineStocks.Any(record => medicineOlds.Any(r => r.ApprovedQuantity < record.AvailableQuantity));
                        if (anyExists)
                        {
                            result.Message = "Không thể hủy phiếu khi đã được sử dụng!";
                            result.IsSuccessed = false;
                        }
                        else
                        {
                            dImpMests.Status = InOutStatusType.Canceled;
                            dImpMests.ModifiedDate = timeNow;
                            dImpMests.ModifiedBy = SessionExtensions.Login?.Id;

                            foreach (var sMedicineStock in sMedicineStocks)
                            {
                                var medicine = medicineOlds.FirstOrDefault(s => s.MedicineId == sMedicineStock.MedicineId && s.ImpStockId == sMedicineStock.StockId);
                                if (medicine != null)
                                {
                                    sMedicineStock.ModifiedDate = timeNow;
                                    sMedicineStock.ModifiedBy = SessionExtensions.Login?.Id;

                                    sMedicineStock.Quantity -= medicine.ApprovedQuantity.GetValueOrDefault();
                                    sMedicineStock.AvailableQuantity -= medicine.ApprovedQuantity.GetValueOrDefault();
                                }
                            }
                        }

                        _dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Lưu phiếu tạm
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromSupplierSaveAsDraft(InOutStockDto input)
        {
            return await ImportFromSupplier(input);
        }

        /// <summary>
        /// Nhập kho
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromSupplierStockIn(InOutStockDto input)
        {
            input.Status = InOutStatusType.ReceivedInStock;
            return await ImportFromSupplier(input);
        }

        /// <summary>
        /// Nhập thuốc từ NCC
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private async Task<ApiResult<InOutStockDto>> ImportFromSupplier(InOutStockDto input)
        {
            var result = new ApiResult<InOutStockDto>();

            result = await ImportFromSupplierValid(input);
            if (!result.IsSuccessed)
            {
                return result;
            }

            using (var transaction = _dbContext.BeginTransaction())
            {
                try
                {
                    var dateNow = DateTime.Now;
                    var id = Guid.NewGuid();
                    input.InOutStockTypeId = (int)Utilities.Enums.InOutStockType.ImportFromSupplier;

                    var inOutStockMedicines = new List<InOutStockMedicine>();
                    var medicines = new List<Medicine>();
                    var medicineStocks = new List<EntityFrameworkCore.Entities.Business.Pharmaceuticals.MedicineStock>();
                    var medicinePricePolicies = new List<MedicinePricePolicy>();

                    if (GuidHelper.IsNullOrEmpty(input.Id))
                    {
                        var dImMest = _mapper.Map<EntityFrameworkCore.Entities.Business.Pharmaceuticals.InOutStock>(input);
                        dImMest.Id = id;
                        dImMest.CreatedBy = SessionExtensions.Login?.Id;
                        dImMest.CreatedDate = dateNow;

                        foreach (var inOutStockMedicineDto in input.InOutStockMedicines)
                        {
                            inOutStockMedicineDto.ApprovedQuantity = inOutStockMedicineDto.RequestQuantity;

                            var medicine = _mapper.Map<Medicine>(inOutStockMedicineDto);
                            if (!GuidHelper.IsNullOrEmpty(inOutStockMedicineDto.MedicineId))
                                medicine.Id = inOutStockMedicineDto.MedicineId.GetValueOrDefault();
                            else
                                medicine.Id = Guid.NewGuid();
                            medicine.CreatedDate = dateNow;
                            medicine.CreatedBy = SessionExtensions.Login?.Id;
                            medicine.ImpQuantity = inOutStockMedicineDto.RequestQuantity;

                            var inOutStockMedicine = _mapper.Map<InOutStockMedicine>(inOutStockMedicineDto);
                            inOutStockMedicine.Id = Guid.NewGuid();
                            inOutStockMedicine.InOutStockId = id;
                            inOutStockMedicine.MedicineId = medicine.Id;

                            if (inOutStockMedicineDto.MedicinePricePolicies != null)
                            {
                                foreach (var sMedicinePricePolicyDto in inOutStockMedicineDto.MedicinePricePolicies)
                                {
                                    var sMedicinePricePolicy = _mapper.Map<MedicinePricePolicy>(sMedicinePricePolicyDto);

                                    if (GuidHelper.IsNullOrEmpty(sMedicinePricePolicy.Id))
                                        sMedicinePricePolicy.Id = Guid.NewGuid();

                                    sMedicinePricePolicy.CreatedDate = dateNow;
                                    sMedicinePricePolicy.CreatedBy = SessionExtensions.Login?.Id;
                                    sMedicinePricePolicy.MedicineId = medicine.Id;

                                    medicinePricePolicies.Add(sMedicinePricePolicy);
                                }
                            }

                            // Trạng thái nhập kho mới thêm vào thuốc trong kho
                            if (input.Status == InOutStatusType.ReceivedInStock)
                            {
                                dImMest.ApproverTime = dateNow;
                                dImMest.ApproverUserId = SessionExtensions.Login?.Id;
                                dImMest.StockImpTime = dateNow;
                                dImMest.StockImpUserId = SessionExtensions.Login?.Id;

                                medicineStocks.Add(new EntityFrameworkCore.Entities.Business.Pharmaceuticals.MedicineStock()
                                {
                                    Id = Guid.NewGuid(),
                                    CreatedDate = dateNow,
                                    CreatedBy = SessionExtensions.Login?.Id,
                                    AvailableQuantity = inOutStockMedicineDto.ApprovedQuantity.GetValueOrDefault(),
                                    Quantity = inOutStockMedicineDto.ApprovedQuantity.GetValueOrDefault(),
                                    StockId = input.ImpStockId,
                                    MedicineId = medicine.Id
                                });
                            }

                            medicines.Add(medicine);
                            inOutStockMedicines.Add(inOutStockMedicine);
                        }

                        if (medicines.Count > 0)
                        {
                            var medicineTypeIds = medicines.Select(s => s.MedicineTypeId).ToList();
                            var medicineTypes = _dbContext.MedicineTypes.Where(w => medicineTypeIds.Contains(w.Id)).ToList();
                            if (medicineTypes != null && medicineTypes.Count > 0)
                            {
                                foreach (var medicine in medicines)
                                {
                                    var medicineType = medicineTypes.FirstOrDefault(f => f.Id == medicine.MedicineTypeId);
                                    if (medicineType != null)
                                    {
                                        medicineType.AutoNumber += 1;
                                        medicine.Code = string.Format("{0}.{1}", medicineType.Code, medicineType.AutoNumber);
                                    }
                                }
                            }
                        }

                        _dbContext.InOutStocks.Add(dImMest);
                    }
                    else
                    {
                        var dImMestOld = _dbContext.InOutStocks.FirstOrDefault(d => d.Id == input.Id);

                        // Xóa bản ghi cũ
                        var inOutStockMedicineOlds = _dbContext.InOutStockMedicines.Where(s => s.InOutStockId == input.Id).ToList();
                        var medicineOldIds = inOutStockMedicineOlds.Select(s => s.MedicineId).ToList();
                        var medicineOlds = _dbContext.Medicines.Where(w => medicineOldIds.Contains(w.Id)).ToList();
                        var medicineStockOlds = _dbContext.MedicineStocks.Where(w => medicineOldIds.Contains(w.MedicineId) && w.StockId == dImMestOld.ImpStockId).ToList();
                        var medicinePricePolicyOlds = _dbContext.MedicinePricePolicies.Where(w => medicineOldIds.Contains(w.MedicineId)).ToList();

                        if (inOutStockMedicineOlds != null && medicineOlds != null)
                        {
                            _dbContext.MedicinePricePolicies.RemoveRange(medicinePricePolicyOlds);
                            _dbContext.MedicineStocks.RemoveRange(medicineStockOlds);
                            _dbContext.InOutStockMedicines.RemoveRange(inOutStockMedicineOlds);
                            _dbContext.Medicines.RemoveRange(medicineOlds);

                            // Chưa biết nguyên nhân: Khi xóa bản ghi cũ và thêm bản ghi mới lại update khóa ngoại về NULL
                            _dbContext.SaveChanges();
                        }

                        foreach (var inOutStockMedicineDto in input.InOutStockMedicines)
                        {
                            inOutStockMedicineDto.ApprovedQuantity = inOutStockMedicineDto.RequestQuantity;

                            var medicine = _mapper.Map<Medicine>(inOutStockMedicineDto);
                            if (!GuidHelper.IsNullOrEmpty(inOutStockMedicineDto.MedicineId))
                            {
                                medicine.Id = inOutStockMedicineDto.MedicineId.GetValueOrDefault();
                                var medicineOld = medicineOlds.FirstOrDefault(f => f.Id == medicine.Id);
                                if (medicineOld != null)
                                    medicine.Code = medicineOld.Code;
                            }
                            else
                            {
                                medicine.Id = Guid.NewGuid();

                                var medicineType = _dbContext.MedicineTypes.FirstOrDefault(f => f.Id == medicine.MedicineTypeId);
                                if (medicineType != null)
                                {
                                    medicineType.AutoNumber += 1;
                                    medicine.Code = string.Format("{0}.{1}", medicineType.Code, medicineType.AutoNumber);
                                }
                            }
                            medicine.CreatedDate = dImMestOld.CreatedDate;
                            medicine.CreatedBy = dImMestOld.CreatedBy;
                            medicine.ModifiedDate = dateNow;
                            medicine.ModifiedBy = SessionExtensions.Login?.Id;
                            medicine.ImpQuantity = inOutStockMedicineDto.RequestQuantity;

                            var inOutStockMedicine = _mapper.Map<InOutStockMedicine>(inOutStockMedicineDto);
                            if (GuidHelper.IsNullOrEmpty(inOutStockMedicine.Id))
                                inOutStockMedicine.Id = Guid.NewGuid();

                            inOutStockMedicine.MedicineId = medicine.Id;
                            inOutStockMedicine.InOutStockId = input.Id;

                            if (inOutStockMedicineDto.MedicinePricePolicies != null)
                            {
                                foreach (var sMedicinePricePolicyDto in inOutStockMedicineDto.MedicinePricePolicies)
                                {
                                    var sMedicinePricePolicy = _mapper.Map<MedicinePricePolicy>(sMedicinePricePolicyDto);

                                    if (GuidHelper.IsNullOrEmpty(sMedicinePricePolicy.Id))
                                        sMedicinePricePolicy.Id = Guid.NewGuid();

                                    sMedicinePricePolicy.CreatedDate = dImMestOld.CreatedDate;
                                    sMedicinePricePolicy.CreatedBy = dImMestOld.CreatedBy;
                                    sMedicinePricePolicy.ModifiedDate = dateNow;
                                    sMedicinePricePolicy.ModifiedBy = SessionExtensions.Login?.Id;
                                    sMedicinePricePolicy.MedicineId = medicine.Id;

                                    medicinePricePolicies.Add(sMedicinePricePolicy);
                                }
                            }

                            // Trạng thái nhập kho mới thêm vào thuốc trong kho
                            if (input.Status == InOutStatusType.ReceivedInStock)
                            {
                                input.ApproverTime = dateNow;
                                input.ApproverUserId = SessionExtensions.Login?.Id;
                                input.StockImpTime = dateNow;
                                input.StockImpUserId = SessionExtensions.Login?.Id;

                                medicineStocks.Add(new EntityFrameworkCore.Entities.Business.Pharmaceuticals.MedicineStock()
                                {
                                    Id = Guid.NewGuid(),
                                    CreatedDate = dateNow,
                                    CreatedBy = SessionExtensions.Login?.Id,
                                    AvailableQuantity = inOutStockMedicineDto.ApprovedQuantity.GetValueOrDefault(),
                                    Quantity = inOutStockMedicineDto.ApprovedQuantity.GetValueOrDefault(),
                                    StockId = input.ImpStockId,
                                    MedicineId = medicine.Id
                                });
                            }

                            medicines.Add(medicine);
                            inOutStockMedicines.Add(inOutStockMedicine);
                        }

                        _mapper.Map(input, dImMestOld);
                        dImMestOld.ModifiedDate = dateNow;
                        dImMestOld.ModifiedBy = SessionExtensions.Login?.Id;
                    }

                    _dbContext.Medicines.AddRange(medicines);
                    _dbContext.InOutStockMedicines.AddRange(inOutStockMedicines);
                    _dbContext.MedicineStocks.AddRange(medicineStocks);
                    _dbContext.MedicinePricePolicies.AddRange(medicinePricePolicies);

                    _dbContext.SaveChanges();
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

        /// <summary>
        /// Ktra trước khi lưu
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private async Task<ApiResult<InOutStockDto>> ImportFromSupplierValid(InOutStockDto input)
        {
            var result = new ApiResult<InOutStockDto>();

            try
            {
                var erros = new List<string>();

                var erroMasters = new List<string>();

                if (GuidHelper.IsNullOrEmpty(input.ImpStockId))
                    erroMasters.Add("Kho nhập");
                if (DatetimeHelper.IsNullOrEmpty(input.ReqTime))
                    erroMasters.Add("Ngày lập");
                if (DatetimeHelper.IsNullOrEmpty(input.InvTime))
                    erroMasters.Add("Ngày HĐ");
                if (GuidHelper.IsNullOrEmpty(input.SupplierId))
                    erroMasters.Add("Nhà cung cấp");

                if (erroMasters.Count > 0)
                    erros.Add(string.Format("{0} không được bỏ trống!", string.Join(", ", erroMasters)));

                if (!string.IsNullOrEmpty(input.Code))
                {
                    var any = _dbContext.InOutStocks.Any(a => a.Id != input.Id && a.Code == input.Code);
                    if (any)
                        erros.Add(string.Format("Mã phiếu nhập [{0}] đã tồn tại trên hệ thống. Vui lòng kiểm tra lại!", input.Code));
                }

                if (input.InOutStockMedicines == null && input.InOutStockMedicines.Count == 0)
                    erros.Add("Không có thuốc nào được chọn trong danh sách!");

                foreach (var detail in input.InOutStockMedicines)
                {
                    var erroMedicines = new List<string>();

                    if (detail.RequestQuantity == 0)
                        erroMedicines.Add("Số lượng");
                    if (DatetimeHelper.IsNullOrEmpty(detail.DueDate))
                        erroMedicines.Add("Hạn dùng");

                    if (erroMedicines.Count > 0)
                    {
                        var erro = string.Format("Mã thuốc {0}: {1} không được để trống!", detail.Code, string.Join(", ", erroMedicines));
                        erros.Add(erro);
                    }
                }

                if (erros.Count > 0)
                {
                    result.Message = string.Join(", ", erros);
                    result.IsSuccessed = false;
                }
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
        #endregion

        #region Nhập từ kho khác
        /// <summary>
        /// Lấy phiếu nhập NCC
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockGetById(Guid id)
        {
            var result = new ApiResult<InOutStockDto>();

            try
            {
                var inOutStockDto = _mapper.Map<InOutStockDto>(_dbContext.InOutStocks.FirstOrDefault(d => d.Id == id));
                if (inOutStockDto != null)
                {
                    // Nhập từ kho khác
                    if (inOutStockDto.InOutStockTypeId == (int)Utilities.Enums.InOutStockType.ImportFromAnotherStock)
                    {
                        var inOutStockMedicineDtos = (from inOutStockMedicine in _dbContext.InOutStockMedicines
                                                      join sMedicine in _dbContext.Medicines on inOutStockMedicine.MedicineId equals sMedicine.Id
                                                      where inOutStockMedicine.InOutStockId == id
                                                      select new InOutStockMedicineDto()
                                                      {
                                                          Id = id,
                                                          Code = sMedicine.Code,
                                                          HeInCode = sMedicine.HeInCode,
                                                          Name = sMedicine.Name,
                                                          MedicineId = inOutStockMedicine.MedicineId,
                                                          SortOrder = sMedicine.SortOrder,
                                                          MedicineLineId = sMedicine.MedicineLineId,
                                                          MedicineGroupId = sMedicine.MedicineGroupId,
                                                          MedicineTypeId = sMedicine.MedicineTypeId,
                                                          UnitId = sMedicine.UnitId,
                                                          Tutorial = sMedicine.Tutorial,
                                                          CountryId = sMedicine.CountryId,
                                                          ImpPrice = sMedicine.ImpPrice,
                                                          RequestQuantity = sMedicine.ImpQuantity,
                                                          ApprovedQuantity = sMedicine.ImpQuantity,
                                                          ImpVatRate = sMedicine.ImpVatRate,
                                                          TaxRate = sMedicine.TaxRate,
                                                          Description = sMedicine.Description,
                                                          ActiveSubstance = sMedicine.ActiveSubstance,
                                                          Concentration = sMedicine.Concentration,
                                                          Content = sMedicine.Content,
                                                          Manufacturer = sMedicine.Manufacturer,
                                                          PackagingSpecifications = sMedicine.PackagingSpecifications,
                                                          Dosage = sMedicine.Dosage,
                                                          Lot = sMedicine.Lot,
                                                          DueDate = sMedicine.DueDate,
                                                          TenderDecision = sMedicine.TenderDecision,
                                                          TenderPackage = sMedicine.TenderPackage,
                                                          TenderGroup = sMedicine.TenderGroup,
                                                          TenderYear = sMedicine.TenderYear,
                                                      }).ToList();


                        inOutStockDto.InOutStockMedicines = inOutStockMedicineDtos;
                    }
                }

                result.Result = inOutStockDto;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        /// <summary>
        /// Lưu phiếu tạm
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockSaveAsDraft(InOutStockDto input)
        {
            input.Status = InOutStatusType.New;
            return await ImportFromAnotherStock(input);
        }

        /// <summary>
        /// Gửi yêu cầu
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockRequest(InOutStockDto input)
        {
            input.Status = InOutStatusType.Request;
            return await ImportFromAnotherStock(input);
        }

        /// <summary>
        /// Nhập kho
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockStockIn(InOutStockDto input)
        {
            input.Status = InOutStatusType.ReceivedInStock;
            return await ImportFromSupplier(input);
        }

        /// <summary>
        /// Nhập thuốc từ kho khác
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private async Task<ApiResult<InOutStockDto>> ImportFromAnotherStock(InOutStockDto input)
        {
            var result = new ApiResult<InOutStockDto>();

            result = await ImportFromAnotherStockValid(input);
            if (!result.IsSuccessed)
            {
                return result;
            }

            using (var transaction = _dbContext.BeginTransaction())
            {
                try
                {
                    var dateNow = DateTime.Now;
                    var id = Guid.NewGuid();

                    input.InOutStockTypeId = (int)Utilities.Enums.InOutStockType.ImportFromAnotherStock;

                    var inOutStock = new EntityFrameworkCore.Entities.Business.Pharmaceuticals.InOutStock();
                    var inOutStockMedicines = new List<InOutStockMedicine>();
                    var medicineStocks = new List<EntityFrameworkCore.Entities.Business.Pharmaceuticals.MedicineStock>();

                    if (GuidHelper.IsNullOrEmpty(input.Id))
                    {
                        inOutStock = _mapper.Map<EntityFrameworkCore.Entities.Business.Pharmaceuticals.InOutStock>(input);
                        inOutStock.Id = id;
                        inOutStock.CreatedBy = SessionExtensions.Login?.Id;
                        inOutStock.CreatedDate = dateNow;

                        foreach (var inOutStockMedicineDto in input.InOutStockMedicines)
                        {
                            var inOutStockMedicine = _mapper.Map<InOutStockMedicine>(inOutStockMedicineDto);
                            inOutStockMedicine.Id = Guid.NewGuid();
                            inOutStockMedicine.InOutStockId = id;

                            inOutStockMedicines.Add(inOutStockMedicine);
                        }

                        // Trạng thái nhập kho mới thêm vào thuốc trong kho
                        if (input.Status == InOutStatusType.ReceivedInStock)
                        {
                            inOutStock.StockImpTime = dateNow;
                            inOutStock.StockImpUserId = SessionExtensions.Login?.Id;

                            var medicineIds = input.InOutStockMedicines.Select(s => s.MedicineId).ToList();
                            if (medicineIds != null && medicineIds.Count > 0)
                            {
                                var medicineStockOlds = _dbContext.MedicineStocks.Where(w => medicineIds.Contains(w.MedicineId) && w.StockId == inOutStock.ImpStockId).ToList();

                                foreach (var inOutStockMedicineDto in input.InOutStockMedicines)
                                {
                                    // Nếu tồn tại thuốc trong kho thì cộng thêm vào tồn và khả dụng
                                    var medicineStock = medicineStockOlds?.FirstOrDefault(f => f.MedicineId == inOutStockMedicineDto.MedicineId);
                                    if (medicineStock != null)
                                    {
                                        medicineStock.ModifiedBy = SessionExtensions.Login?.Id;
                                        medicineStock.ModifiedDate = dateNow;

                                        medicineStock.AvailableQuantity += inOutStockMedicineDto.ApprovedQuantity.GetValueOrDefault();
                                        medicineStock.Quantity += inOutStockMedicineDto.ApprovedQuantity.GetValueOrDefault();
                                    }
                                    else // Nếu chưa tồn tại thuốc trong kho thì thêm mới thuốc vào kho
                                    {
                                        medicineStocks.Add(new EntityFrameworkCore.Entities.Business.Pharmaceuticals.MedicineStock()
                                        {
                                            Id = Guid.NewGuid(),
                                            CreatedDate = dateNow,
                                            CreatedBy = SessionExtensions.Login?.Id,
                                            AvailableQuantity = inOutStockMedicineDto.ApprovedQuantity.GetValueOrDefault(),
                                            Quantity = inOutStockMedicineDto.ApprovedQuantity.GetValueOrDefault(),
                                            StockId = input.ImpStockId,
                                            MedicineId = inOutStockMedicineDto.MedicineId
                                        });
                                    }
                                }
                            }
                        }

                        _dbContext.InOutStocks.Add(inOutStock);
                    }
                    else
                    {
                        inOutStock = _dbContext.InOutStocks.FirstOrDefault(d => d.Id == input.Id);

                        // Xóa bản ghi cũ
                        var inOutStockMedicineOlds = _dbContext.InOutStockMedicines.Where(s => s.InOutStockId == input.Id).ToList();
                        if (inOutStockMedicineOlds != null)
                        {
                            _dbContext.InOutStockMedicines.RemoveRange(inOutStockMedicineOlds);
                        }

                        foreach (var inOutStockMedicineDto in input.InOutStockMedicines)
                        {
                            var inOutStockMedicine = _mapper.Map<InOutStockMedicine>(inOutStockMedicineDto);
                            if (GuidHelper.IsNullOrEmpty(inOutStockMedicine.Id))
                                inOutStockMedicine.Id = Guid.NewGuid();
                            inOutStockMedicine.InOutStockId = input.Id;

                            inOutStockMedicines.Add(inOutStockMedicine);
                        }

                        // Trạng thái nhập kho mới thêm vào thuốc trong kho
                        if (input.Status == InOutStatusType.ReceivedInStock)
                        {
                            input.StockImpTime = dateNow;
                            input.StockImpUserId = SessionExtensions.Login?.Id;

                            var medicineIds = input.InOutStockMedicines.Select(s => s.MedicineId).ToList();
                            if (medicineIds != null && medicineIds.Count > 0)
                            {
                                var medicineStockOlds = _dbContext.MedicineStocks.Where(w => medicineIds.Contains(w.MedicineId) && w.StockId == inOutStock.ImpStockId).ToList();

                                foreach (var dImMestMedicineDto in input.InOutStockMedicines)
                                {
                                    // Nếu tồn tại thuốc trong kho thì cộng thêm vào tồn và khả dụng
                                    var medicineStock = medicineStockOlds?.FirstOrDefault(f => f.MedicineId == dImMestMedicineDto.MedicineId);
                                    if (medicineStock != null)
                                    {
                                        medicineStock.ModifiedBy = SessionExtensions.Login?.Id;
                                        medicineStock.ModifiedDate = dateNow;

                                        medicineStock.AvailableQuantity += dImMestMedicineDto.ApprovedQuantity.GetValueOrDefault();
                                        medicineStock.Quantity += dImMestMedicineDto.ApprovedQuantity.GetValueOrDefault();
                                    }
                                    else // Nếu chưa tồn tại thuốc trong kho thì thêm mới thuốc vào kho
                                    {
                                        medicineStocks.Add(new EntityFrameworkCore.Entities.Business.Pharmaceuticals.MedicineStock()
                                        {
                                            Id = Guid.NewGuid(),
                                            CreatedDate = dateNow,
                                            CreatedBy = SessionExtensions.Login?.Id,
                                            AvailableQuantity = dImMestMedicineDto.ApprovedQuantity.GetValueOrDefault(),
                                            Quantity = dImMestMedicineDto.ApprovedQuantity.GetValueOrDefault(),
                                            StockId = input.ImpStockId,
                                            MedicineId = dImMestMedicineDto.MedicineId
                                        });
                                    }
                                }
                            }
                        }

                        _mapper.Map(input, inOutStock);
                        inOutStock.ModifiedDate = dateNow;
                        inOutStock.ModifiedBy = SessionExtensions.Login?.Id;
                    }

                    _dbContext.InOutStockMedicines.AddRange(inOutStockMedicines);
                    _dbContext.MedicineStocks.AddRange(medicineStocks);

                    _dbContext.SaveChanges();
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

        private async Task<ApiResult<InOutStockDto>> ImportFromAnotherStockValid(InOutStockDto input)
        {
            var result = new ApiResult<InOutStockDto>();

            try
            {
                var erros = new List<string>();

                var erroMasters = new List<string>();

                if (GuidHelper.IsNullOrEmpty(input.ImpStockId))
                    erroMasters.Add("Kho nhập");
                if (GuidHelper.IsNullOrEmpty(input.ExpStockId))
                    erroMasters.Add("Kho Xuất");
                if (DatetimeHelper.IsNullOrEmpty(input.ReqTime))
                    erroMasters.Add("Ngày lập");
                if (GuidHelper.IsNullOrEmpty(input.CreationUserId))
                    erroMasters.Add("Người lập");

                if (erroMasters.Count > 0)
                    erros.Add(string.Format("{0} không được bỏ trống!", string.Join(", ", erroMasters)));

                if (input.InOutStockMedicines == null && input.InOutStockMedicines.Count == 0)
                    erros.Add("Không có thuốc nào được chọn trong danh sách!");

                foreach (var detail in input.InOutStockMedicines)
                {
                    var erroMedicines = new List<string>();

                    if (detail.RequestQuantity == 0)
                        erroMedicines.Add("Số lượng");
                    if (DatetimeHelper.IsNullOrEmpty(detail.DueDate))
                        erroMedicines.Add("Hạn dùng");

                    if (erroMedicines.Count > 0)
                    {
                        var erro = string.Format("Mã thuốc {0}: {1} không được để trống!", detail.Code, string.Join(", ", erroMedicines));
                        erros.Add(erro);
                    }
                }

                // Ktra SL tồn, khả dụng có đủ để xuất ko
                var medicineIds = input.InOutStockMedicines.Select(s => s.MedicineId).ToList();
                if (medicineIds != null && medicineIds.Count > 0)
                {
                    var medicineStocks = _dbContext.MedicineStocks.Where(w => medicineIds.Contains(w.MedicineId) && w.StockId == input.ExpStockId).ToList();
                    if (medicineStocks != null)
                    {
                        foreach (var item in input.InOutStockMedicines)
                        {
                            var medicineStock = medicineStocks.FirstOrDefault(f => f.MedicineId == item.MedicineId);
                            if (medicineStock != null)
                            {
                                if (item.RequestQuantity > medicineStock.AvailableQuantity)
                                {
                                    erros.Add(string.Format("Mã thuốc [{0}]: Số lượng nhập phải nhỏ hơn số lượng tồn kho!", item.Code));
                                }
                            }
                            else
                            {
                                erros.Add(string.Format("Mã thuốc [{0}] không tồn tại trong kho!", item.Code));
                            }
                        }
                    }
                }

                if (erros.Count > 0)
                {
                    result.Message = string.Join(", ", erros);
                    result.IsSuccessed = false;
                }
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
        #endregion

    }
}
