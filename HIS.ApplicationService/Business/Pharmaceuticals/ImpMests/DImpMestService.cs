using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Business.DImMest;
using HIS.Dtos.Business.DImMestMedicine;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicinePricePolicy;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.ImpMests;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Medicines;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Globalization;

namespace HIS.ApplicationService.Business.Pharmaceuticals.ImpMests
{
    public class DImpMestService : BaseSerivce, IDImpMestService
    {
        public DImpMestService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
           : base(dbContext, config, mapper) { }

        public async Task<ApiResultList<DImpMestDto>> GetByStock(Guid stockId, string fromDate, string toDate)
        {
            var result = new ApiResultList<DImpMestDto>();

            try
            {
                DateTime fromDateTime = DateTime.ParseExact(fromDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);
                DateTime toDateTime = DateTime.ParseExact(toDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);

                result.Result = (from dImMest in _dbContext.DImpMests

                                 join imStock in _dbContext.SRooms on dImMest.ImStockId equals imStock.Id into imStockDefaults
                                 from imStockDefault in imStockDefaults.DefaultIfEmpty()

                                 join exStock in _dbContext.SRooms on dImMest.ExStockId equals exStock.Id into exStockDefaults
                                 from exStockDefault in exStockDefaults.DefaultIfEmpty()

                                 join impExpMestType in _dbContext.DImpExpMestTypes on dImMest.ImpExpMestTypeId equals impExpMestType.Id into impExpMestTypeDefaults
                                 from impExpMestTypeDefault in impExpMestTypeDefaults.DefaultIfEmpty()

                                 select new DImpMestDto()
                                 {
                                     Id = dImMest.Id,
                                     Code = dImMest.Code,
                                     Name = dImMest.Code,
                                     ImpMestStatus = dImMest.ImpMestStatus,
                                     ImStockId = dImMest.ImStockId,
                                     ImStockCode = imStockDefault != null ? imStockDefault.Code : null,
                                     ImStockName = imStockDefault != null ? imStockDefault.Name : null,
                                     ExStockId = dImMest.ExStockId,
                                     ExStockCode = exStockDefault != null ? exStockDefault.Code : null,
                                     ExStockName = exStockDefault != null ? exStockDefault.Name : null,
                                     ImpExpMestTypeId = dImMest.ImpExpMestTypeId,
                                     ImpExpMestTypeName = impExpMestTypeDefault != null ? impExpMestTypeDefault.Name : null,
                                     ReceiverUserId = dImMest.ReceiverUserId,
                                     ApproverUserId = dImMest.ApproverUserId,
                                     ImpTime = dImMest.ImpTime.Value,
                                     ImpUserId = dImMest.ImpUserId,
                                     StockReceiptUserId = dImMest.StockReceiptUserId,
                                     StockReceiptTime = dImMest.StockReceiptTime,
                                     ApproverTime = dImMest.ApproverTime,
                                     Description = dImMest.Description,
                                     ReqRoomId = dImMest.ReqRoomId,
                                     ReqDepartmentId = dImMest.ReqDepartmentId,
                                     TreatmentId = dImMest.TreatmentId,
                                     PatientId = dImMest.PatientId,
                                     SupplierId = dImMest.SupplierId,
                                     InvTime = dImMest.InvTime,
                                     Deliverer = dImMest.Deliverer
                                 })
                                 .WhereIf(fromDateTime != (DateTime)default, w => w.ImpTime >= fromDateTime)
                                 .WhereIf(toDateTime != (DateTime)default, w => w.ImpTime <= toDateTime)
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(stockId), w => w.ImStockId == stockId || w.ExStockId == stockId)
                                 .ToList();
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }


            return await Task.FromResult(result);
        }

        public async Task<ApiResult<DImpMestDto>> GetById(Guid id)
        {
            var result = new ApiResult<DImpMestDto>();

            try
            {
                var dImpMestDto = _mapper.Map<DImpMestDto>(_dbContext.DImpMests.FirstOrDefault(d => d.Id == id));
                if (dImpMestDto != null)
                {
                    // Nhập thuốc NCC
                    if (dImpMestDto.ImpExpMestTypeId == 1)
                    {
                        var dImpMestMedicineDtos = _mapper.Map<IList<DImpMestMedicineDto>>(_dbContext.DImpMestMedicines.Where(w => w.ImpMestId == id).ToList());
                        var sMedicineIds = dImpMestMedicineDtos.Select(s => s.MedicineId).ToList();
                        var sMedicineDtos = _mapper.Map<IList<SMedicine>>(_dbContext.SMedicines.Where(w => sMedicineIds.Contains(w.Id)).ToList());

                        var sMedicinePricePolicyDtos = (from med in _dbContext.SMedicinePricePolicies
                                                        join pa in _dbContext.SPatientTypes on med.PatientTypeId equals pa.Id
                                                        select new SMedicinePricePolicyDto()
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
                                                      .WhereIf(sMedicineIds != null, w => sMedicineIds.Contains(w.MedicineId))
                                                      .OrderBy(s => s.PatientTypeCode).ToList();

                        foreach (var dImpMestMedicine in dImpMestMedicineDtos)
                        {
                            var sMedicine = sMedicineDtos.FirstOrDefault(f => f.Id == dImpMestMedicine.MedicineId);

                            dImpMestMedicine.Code = sMedicine.Code;
                            dImpMestMedicine.HeInCode = sMedicine.HeInCode;
                            dImpMestMedicine.Name = sMedicine.Name;
                            dImpMestMedicine.SortOrder = sMedicine.SortOrder;
                            dImpMestMedicine.MedicineLineId = sMedicine.MedicineLineId;
                            dImpMestMedicine.MedicineGroupId = sMedicine.MedicineGroupId;
                            dImpMestMedicine.MedicineTypeId = sMedicine.MedicineTypeId;
                            dImpMestMedicine.UnitId = sMedicine.UnitId;
                            dImpMestMedicine.Tutorial = sMedicine.Tutorial;
                            dImpMestMedicine.CountryId = sMedicine.CountryId;
                            dImpMestMedicine.ImpPrice = sMedicine.ImpPrice;
                            dImpMestMedicine.ImpQuantity = sMedicine.ImpQuantity;
                            dImpMestMedicine.ImpVatRate = sMedicine.ImpVatRate;
                            dImpMestMedicine.TaxRate = sMedicine.TaxRate;
                            dImpMestMedicine.Description = sMedicine.Description;
                            dImpMestMedicine.ActiveSubstance = sMedicine.ActiveSubstance;
                            dImpMestMedicine.Concentration = sMedicine.Concentration;
                            dImpMestMedicine.Content = sMedicine.Content;
                            dImpMestMedicine.Manufacturer = sMedicine.Manufacturer;
                            dImpMestMedicine.PackagingSpecifications = sMedicine.PackagingSpecifications;
                            dImpMestMedicine.Dosage = sMedicine.Dosage;
                            dImpMestMedicine.Lot = sMedicine.Lot;
                            dImpMestMedicine.DueDate = sMedicine.DueDate;
                            dImpMestMedicine.TenderDecision = sMedicine.TenderDecision;
                            dImpMestMedicine.TenderPackage = sMedicine.TenderPackage;
                            dImpMestMedicine.TenderGroup = sMedicine.TenderGroup;
                            dImpMestMedicine.TenderYear = sMedicine.TenderYear;

                            dImpMestMedicine.SMedicinePricePolicies = sMedicinePricePolicyDtos.Where(w => w.MedicineId == dImpMestMedicine.MedicineId).ToList();
                        }

                        dImpMestDto.DImpMestMedicines = dImpMestMedicineDtos;
                    }
                }

                result.Result = dImpMestDto;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<bool>> ImportFromSupplierCanceled(Guid id)
        {
            var result = new ApiResult<bool>();

            try
            {
                var timeNow = DateTime.Now;

                var dImpMests = _dbContext.DImpMests.FirstOrDefault(w => w.Id == id);

                // Nhập thuốc từ nhà cung cấp
                if (dImpMests.ImpExpMestTypeId == 1)
                {
                    var medicineOlds = (from dImpMest in _dbContext.DImpMests
                                        join dImpMestMedicine in _dbContext.DImpMestMedicines on dImpMest.Id equals dImpMestMedicine.ImpMestId
                                        where dImpMest.Id == id && dImpMest.IsDeleted == false
                                        select new
                                        {
                                            dImpMestMedicine.Id,
                                            dImpMestMedicine.MedicineId,
                                            dImpMestMedicine.ImpQuantity,
                                            dImpMest.ImStockId,
                                            dImpMest.ImpExpMestTypeId,
                                        }).Distinct().ToList();


                    if (medicineOlds != null && medicineOlds.Count > 0)
                    {
                        var stockId = medicineOlds.Select(s => s.ImStockId).Distinct().ToList();
                        var medicinIds = medicineOlds.Select(s => s.MedicineId).Distinct().ToList();
                        var sMedicineStocks = _dbContext.DMedicineStocks.Where(w => stockId.Contains(w.StockId) && medicinIds.Contains(w.MedicineId)).ToList();

                        // Ktra số lượng đã bị xuất nhập chưa để hủy phiếu
                        bool anyExists = sMedicineStocks.Any(record => medicineOlds.Any(r => r.ImpQuantity < record.AvailableQuantity));
                        if (anyExists)
                        {
                            result.Message = "Không thể hủy phiếu khi đã được sử dụng!";
                            result.IsSuccessed = false;
                        }
                        else
                        {
                            dImpMests.ImpMestStatus = ImpMestStatusType.Canceled;
                            dImpMests.ModifiedDate = timeNow;
                            dImpMests.ModifiedBy = SessionExtensions.Login?.Id;

                            foreach (var sMedicineStock in sMedicineStocks)
                            {
                                var medicine = medicineOlds.FirstOrDefault(s => s.MedicineId == sMedicineStock.MedicineId && s.ImStockId == sMedicineStock.StockId);
                                if (medicine != null)
                                {
                                    sMedicineStock.ModifiedDate = timeNow;
                                    sMedicineStock.ModifiedBy = SessionExtensions.Login?.Id;

                                    sMedicineStock.Quantity -= medicine.ImpQuantity.GetValueOrDefault();
                                    sMedicineStock.AvailableQuantity -= medicine.ImpQuantity.GetValueOrDefault();
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

        public async Task<ApiResult<DImpMestDto>> ImportFromSupplierSaveAsDraft(DImpMestDto input)
        {
            return await ImportFromSupplier(input);
        }

        public async Task<ApiResult<DImpMestDto>> ImportFromSupplierStockIn(DImpMestDto input)
        {
            input.ImpMestStatus = ImpMestStatusType.ReceivedInStock;
            return await ImportFromSupplier(input);
        }

        private async Task<ApiResult<DImpMestDto>> ImportFromSupplier(DImpMestDto input)
        {
            var result = new ApiResult<DImpMestDto>();

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var dateNow = DateTime.Now;
                    var id = Guid.NewGuid();

                    var dImMestMedicines = new List<DImpMestMedicine>();
                    var sMedicines = new List<SMedicine>();
                    var dMedicineStocks = new List<EntityFrameworkCore.Entities.Business.Pharmaceuticals.DMedicineStock>();
                    var sMedicinePricePolicies = new List<SMedicinePricePolicy>();

                    if (GuidHelper.IsNullOrEmpty(input.Id))
                    {
                        var dImMest = _mapper.Map<DImpMest>(input);
                        dImMest.Id = id;
                        dImMest.CreatedDate = dateNow;

                        foreach (var dImMestMedicineDto in input.DImpMestMedicines)
                        {
                            var sMedicine = _mapper.Map<SMedicine>(dImMestMedicineDto);
                            sMedicine.Id = Guid.NewGuid();
                            sMedicine.CreatedDate = dateNow;
                            sMedicine.CreatedBy = SessionExtensions.Login?.Id;

                            var dImMestMedicine = _mapper.Map<DImpMestMedicine>(dImMestMedicineDto);
                            dImMestMedicine.Id = Guid.NewGuid();
                            dImMestMedicine.ImpMestId = id;
                            dImMestMedicine.MedicineId = sMedicine.Id;

                            if (dImMestMedicineDto.SMedicinePricePolicies != null)
                            {
                                foreach (var sMedicinePricePolicyDto in dImMestMedicineDto.SMedicinePricePolicies)
                                {
                                    var sMedicinePricePolicy = _mapper.Map<SMedicinePricePolicy>(sMedicinePricePolicyDto);

                                    if (GuidHelper.IsNullOrEmpty(sMedicinePricePolicy.Id))
                                        sMedicinePricePolicy.Id = Guid.NewGuid();

                                    sMedicinePricePolicy.CreatedDate = dateNow;
                                    sMedicinePricePolicy.CreatedBy = SessionExtensions.Login?.Id;
                                    sMedicinePricePolicy.MedicineId = sMedicine.Id;

                                    sMedicinePricePolicies.Add(sMedicinePricePolicy);
                                }
                            }

                            // Trạng thái nhập kho mới thêm vào thuốc trong kho
                            if (input.ImpMestStatus == ImpMestStatusType.ReceivedInStock)
                            {
                                dImMest.ApproverTime = dateNow;
                                dImMest.ApproverUserId = SessionExtensions.Login?.Id;
                                dImMest.StockReceiptTime = dateNow;
                                dImMest.StockReceiptUserId = SessionExtensions.Login?.Id;

                                dMedicineStocks.Add(new EntityFrameworkCore.Entities.Business.Pharmaceuticals.DMedicineStock()
                                {
                                    Id = Guid.NewGuid(),
                                    CreatedDate = dateNow,
                                    CreatedBy = SessionExtensions.Login?.Id,
                                    AvailableQuantity = dImMestMedicineDto.ImpQuantity.GetValueOrDefault(),
                                    Quantity = dImMestMedicineDto.ImpQuantity.GetValueOrDefault(),
                                    StockId = input.ImStockId,
                                    MedicineId = sMedicine.Id
                                });
                            }

                            sMedicines.Add(sMedicine);
                            dImMestMedicines.Add(dImMestMedicine);
                        }

                        _dbContext.DImpMests.Add(dImMest);
                    }
                    else
                    {
                        var dImMestOld = _dbContext.DImpMests.FirstOrDefault(d => d.Id == input.Id);

                        // Xóa bản ghi cũ
                        var dImMestMedicineOlds = _dbContext.DImpMestMedicines.Where(s => s.ImpMestId == input.Id).ToList();
                        var sMedicineOldIds = dImMestMedicineOlds.Select(s => s.MedicineId).ToList();
                        var sMedicineOlds = _dbContext.SMedicines.Where(w => sMedicineOldIds.Contains(w.Id)).ToList();
                        var dMedicineStockOlds = _dbContext.DMedicineStocks.Where(w => sMedicineOldIds.Contains(w.MedicineId)).ToList();
                        var sMedicinePricePolicyDtos = _dbContext.SMedicinePricePolicies.Where(w => sMedicineOldIds.Contains(w.MedicineId)).ToList();

                        if (dImMestMedicineOlds != null && sMedicineOlds != null)
                        {
                            _dbContext.SMedicinePricePolicies.RemoveRange(sMedicinePricePolicyDtos);
                            _dbContext.DMedicineStocks.RemoveRange(dMedicineStockOlds);
                            _dbContext.DImpMestMedicines.RemoveRange(dImMestMedicineOlds);
                            _dbContext.SMedicines.RemoveRange(sMedicineOlds);

                            _dbContext.SaveChanges();
                        }

                        foreach (var dImMestMedicineDto in input.DImpMestMedicines)
                        {
                            var sMedicine = _mapper.Map<SMedicine>(dImMestMedicineDto);
                            if (GuidHelper.IsNullOrEmpty(sMedicine.Id))
                                sMedicine.Id = Guid.NewGuid();
                            sMedicine.CreatedDate = dImMestOld.CreatedDate;
                            sMedicine.CreatedBy = dImMestOld.CreatedBy;
                            sMedicine.ModifiedDate = dateNow;
                            sMedicine.ModifiedBy = SessionExtensions.Login?.Id;

                            var dImMestMedicine = _mapper.Map<DImpMestMedicine>(dImMestMedicineDto);
                            if (GuidHelper.IsNullOrEmpty(dImMestMedicine.Id))
                                dImMestMedicine.Id = Guid.NewGuid();
                            dImMestMedicine.MedicineId = sMedicine.Id;
                            dImMestMedicine.ImpMestId = input.Id;

                            if (dImMestMedicineDto.SMedicinePricePolicies != null)
                            {
                                foreach (var sMedicinePricePolicyDto in dImMestMedicineDto.SMedicinePricePolicies)
                                {
                                    var sMedicinePricePolicy = _mapper.Map<SMedicinePricePolicy>(sMedicinePricePolicyDto);

                                    if (GuidHelper.IsNullOrEmpty(sMedicinePricePolicy.Id))
                                        sMedicinePricePolicy.Id = Guid.NewGuid();

                                    sMedicinePricePolicy.CreatedDate = dImMestOld.CreatedDate;
                                    sMedicinePricePolicy.CreatedBy = dImMestOld.CreatedBy;
                                    sMedicinePricePolicy.ModifiedDate = dateNow;
                                    sMedicinePricePolicy.ModifiedBy = SessionExtensions.Login?.Id;
                                    sMedicinePricePolicy.MedicineId = sMedicine.Id;

                                    sMedicinePricePolicies.Add(sMedicinePricePolicy);
                                }
                            }

                            // Trạng thái nhập kho mới thêm vào thuốc trong kho
                            if (input.ImpMestStatus == ImpMestStatusType.ReceivedInStock)
                            {
                                dImMestOld.ApproverTime = dateNow;
                                dImMestOld.ApproverUserId = SessionExtensions.Login?.Id;
                                dImMestOld.StockReceiptTime = dateNow;
                                dImMestOld.StockReceiptUserId = SessionExtensions.Login?.Id;

                                dMedicineStocks.Add(new EntityFrameworkCore.Entities.Business.Pharmaceuticals.DMedicineStock()
                                {
                                    Id = Guid.NewGuid(),
                                    CreatedDate = dateNow,
                                    CreatedBy = SessionExtensions.Login?.Id,
                                    AvailableQuantity = dImMestMedicineDto.ImpQuantity.GetValueOrDefault(),
                                    Quantity = dImMestMedicineDto.ImpQuantity.GetValueOrDefault(),
                                    StockId = input.ImStockId,
                                    MedicineId = sMedicine.Id
                                });
                            }

                            sMedicines.Add(sMedicine);
                            dImMestMedicines.Add(dImMestMedicine);
                        }

                        _mapper.Map(input, dImMestOld);
                        dImMestOld.ModifiedDate = dateNow;
                    }

                    await _dbContext.SMedicines.AddRangeAsync(sMedicines);
                    await _dbContext.DImpMestMedicines.AddRangeAsync(dImMestMedicines);
                    await _dbContext.DMedicineStocks.AddRangeAsync(dMedicineStocks);
                    await _dbContext.SMedicinePricePolicies.AddRangeAsync(sMedicinePricePolicies);

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
    }
}
