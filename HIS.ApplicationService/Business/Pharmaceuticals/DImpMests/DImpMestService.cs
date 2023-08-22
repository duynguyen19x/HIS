using AutoMapper;
using HIS.ApplicationService.Business.Pharmaceuticals.DExpMests;
using HIS.Core.Linq;
using HIS.Dtos.Business.DImMestMedicine;
using HIS.Dtos.Business.DImpMest;
using HIS.Dtos.Business.DMedicineStock;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Medicine;
using HIS.Dtos.Dictionaries.MedicinePricePolicy;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.DImpMests;
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

namespace HIS.ApplicationService.Business.Pharmaceuticals.DImpMests
{
    public class DImpMestService : BaseSerivce, IDImpMestService
    {
        private readonly IDExpMestService _dExpMestService;

        public DImpMestService(HISDbContext dbContext, IConfiguration config, IMapper mapper, IDExpMestService dExpMestService)
           : base(dbContext, config, mapper)
        {
            _dExpMestService = dExpMestService;
        }

        public async Task<ApiResultList<DImpMestDto>> GetByStocks(Guid stockId, string fromDate, string toDate)
        {
            var result = new ApiResultList<DImpMestDto>();

            try
            {
                DateTime fromDateTime = DateTime.ParseExact(fromDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);
                DateTime toDateTime = DateTime.ParseExact(toDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);

                result.Result = (from dImMest in _dbContext.DImpMests

                                 join imStock in _dbContext.SRooms on dImMest.ImpStockId equals imStock.Id into imStockDefaults
                                 from imStockDefault in imStockDefaults.DefaultIfEmpty()

                                 join exStock in _dbContext.SRooms on dImMest.ExpStockId equals exStock.Id into exStockDefaults
                                 from exStockDefault in exStockDefaults.DefaultIfEmpty()

                                 join impExpMestType in _dbContext.DImpExpMestTypes on dImMest.ImpExpMestTypeId equals impExpMestType.Id into impExpMestTypeDefaults
                                 from impExpMestTypeDefault in impExpMestTypeDefaults.DefaultIfEmpty()

                                 select new DImpMestDto()
                                 {
                                     Id = dImMest.Id,
                                     Code = dImMest.Code,
                                     ImpMestStatus = dImMest.ImpMestStatus,
                                     ExpMestStatus = dImMest.ExpMestStatus,
                                     ImpStockId = dImMest.ImpStockId,
                                     ImpStockCode = imStockDefault != null ? imStockDefault.Code : null,
                                     ImpStockName = imStockDefault != null ? imStockDefault.Name : null,
                                     ExpStockId = dImMest.ExpStockId,
                                     ExpStockCode = exStockDefault != null ? exStockDefault.Code : null,
                                     ExpStockName = exStockDefault != null ? exStockDefault.Name : null,
                                     ImpExpMestTypeId = dImMest.ImpExpMestTypeId,
                                     ImpExpMestTypeName = impExpMestTypeDefault != null ? impExpMestTypeDefault.Name : null,
                                     ReceiverUserId = dImMest.ReceiverUserId,
                                     ApproverUserId = dImMest.ApproverUserId,
                                     ImpTime = dImMest.ImpTime.Value,
                                     ImpUserId = dImMest.ImpUserId,
                                     StockImpUserId = dImMest.StockImpUserId,
                                     StockImpTime = dImMest.StockImpTime,
                                     ApproverTime = dImMest.ApproverTime,
                                     Description = dImMest.Description,
                                     ReqRoomId = dImMest.ReqRoomId,
                                     ReqDepartmentId = dImMest.ReqDepartmentId,
                                     PatientRecordId = dImMest.PatientRecordId,
                                     PatientId = dImMest.PatientId,
                                     SupplierId = dImMest.SupplierId,
                                     InvTime = dImMest.InvTime,
                                     Deliverer = dImMest.Deliverer
                                 })
                                 .WhereIf(fromDateTime != (DateTime)default, w => w.ImpTime >= fromDateTime)
                                 .WhereIf(toDateTime != (DateTime)default, w => w.ImpTime <= toDateTime)
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

        public async Task<ApiResultList<DMedicineStockDto>> GetMedicineByStocks(Guid stockId)
        {
            var result = new ApiResultList<DMedicineStockDto>();

            try
            {
                result.Result = (from dMedicineStock in _dbContext.DMedicineStocks
                                 join sMedicine in _dbContext.SMedicines on dMedicineStock.MedicineId equals sMedicine.Id

                                 where dMedicineStock.IsDeleted == false && dMedicineStock.AvailableQuantity > 0

                                 select new DMedicineStockDto()
                                 {
                                     Id = dMedicineStock.Id,
                                     MedicineCode = sMedicine.Code,
                                     MedicineName = sMedicine.Name,
                                     StockId = dMedicineStock.StockId,
                                     MedicineId = dMedicineStock.MedicineId,
                                     Quantity = dMedicineStock.Quantity,
                                     AvailableQuantity = dMedicineStock.AvailableQuantity,
                                     SMedicine = _mapper.Map<SMedicineDto>(sMedicine)
                                 }).ToList();
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
        public async Task<ApiResult<DImpMestDto>> ImportFromSupplierGetById(Guid id)
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

                            if (!string.IsNullOrEmpty(sMedicine.Code))
                                dImpMestMedicine.Code = sMedicine.Code.Split('.')?[0];

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
                                            dImpMest.ImpStockId,
                                            dImpMest.ImpExpMestTypeId,
                                        }).Distinct().ToList();


                    if (medicineOlds != null && medicineOlds.Count > 0)
                    {
                        var stockId = medicineOlds.Select(s => s.ImpStockId).Distinct().ToList();
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
                                var medicine = medicineOlds.FirstOrDefault(s => s.MedicineId == sMedicineStock.MedicineId && s.ImpStockId == sMedicineStock.StockId);
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

        /// <summary>
        /// Lưu phiếu tạm
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<DImpMestDto>> ImportFromSupplierSaveAsDraft(DImpMestDto input)
        {
            return await ImportFromSupplier(input);
        }

        /// <summary>
        /// Nhập kho
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<DImpMestDto>> ImportFromSupplierStockIn(DImpMestDto input)
        {
            input.ImpMestStatus = ImpMestStatusType.ReceivedInStock;
            return await ImportFromSupplier(input);
        }

        /// <summary>
        /// Nhập thuốc từ NCC
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private async Task<ApiResult<DImpMestDto>> ImportFromSupplier(DImpMestDto input)
        {
            var result = new ApiResult<DImpMestDto>();

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
                    input.ImpExpMestTypeId = 1;

                    var dImMestMedicines = new List<DImpMestMedicine>();
                    var sMedicines = new List<SMedicine>();
                    var dMedicineStocks = new List<EntityFrameworkCore.Entities.Business.Pharmaceuticals.DMedicineStock>();
                    var sMedicinePricePolicies = new List<SMedicinePricePolicy>();

                    if (GuidHelper.IsNullOrEmpty(input.Id))
                    {
                        var dImMest = _mapper.Map<DImpMest>(input);
                        dImMest.Id = id;
                        dImMest.CreatedBy = SessionExtensions.Login?.Id;
                        dImMest.CreatedDate = dateNow;

                        foreach (var dImMestMedicineDto in input.DImpMestMedicines)
                        {
                            var sMedicine = _mapper.Map<SMedicine>(dImMestMedicineDto);
                            if (!GuidHelper.IsNullOrEmpty(dImMestMedicineDto.MedicineId))
                                sMedicine.Id = dImMestMedicineDto.MedicineId.GetValueOrDefault();
                            else
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
                                dImMest.StockImpTime = dateNow;
                                dImMest.StockImpUserId = SessionExtensions.Login?.Id;

                                dMedicineStocks.Add(new EntityFrameworkCore.Entities.Business.Pharmaceuticals.DMedicineStock()
                                {
                                    Id = Guid.NewGuid(),
                                    CreatedDate = dateNow,
                                    CreatedBy = SessionExtensions.Login?.Id,
                                    AvailableQuantity = dImMestMedicineDto.ImpQuantity.GetValueOrDefault(),
                                    Quantity = dImMestMedicineDto.ImpQuantity.GetValueOrDefault(),
                                    StockId = input.ImpStockId,
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
                        var dMedicineStockOlds = _dbContext.DMedicineStocks.Where(w => sMedicineOldIds.Contains(w.MedicineId) && w.StockId == dImMestOld.ImpStockId).ToList();
                        var sMedicinePricePolicyOlds = _dbContext.SMedicinePricePolicies.Where(w => sMedicineOldIds.Contains(w.MedicineId)).ToList();

                        if (dImMestMedicineOlds != null && sMedicineOlds != null)
                        {
                            _dbContext.SMedicinePricePolicies.RemoveRange(sMedicinePricePolicyOlds);
                            _dbContext.DMedicineStocks.RemoveRange(dMedicineStockOlds);
                            _dbContext.DImpMestMedicines.RemoveRange(dImMestMedicineOlds);
                            _dbContext.SMedicines.RemoveRange(sMedicineOlds);

                            _dbContext.SaveChanges();
                        }

                        foreach (var dImMestMedicineDto in input.DImpMestMedicines)
                        {
                            var sMedicine = _mapper.Map<SMedicine>(dImMestMedicineDto);
                            if (!GuidHelper.IsNullOrEmpty(dImMestMedicineDto.MedicineId))
                                sMedicine.Id = dImMestMedicineDto.MedicineId.GetValueOrDefault();
                            else
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
                                input.ApproverTime = dateNow;
                                input.ApproverUserId = SessionExtensions.Login?.Id;
                                input.StockImpTime = dateNow;
                                input.StockImpUserId = SessionExtensions.Login?.Id;

                                dMedicineStocks.Add(new EntityFrameworkCore.Entities.Business.Pharmaceuticals.DMedicineStock()
                                {
                                    Id = Guid.NewGuid(),
                                    CreatedDate = dateNow,
                                    CreatedBy = SessionExtensions.Login?.Id,
                                    AvailableQuantity = dImMestMedicineDto.ImpQuantity.GetValueOrDefault(),
                                    Quantity = dImMestMedicineDto.ImpQuantity.GetValueOrDefault(),
                                    StockId = input.ImpStockId,
                                    MedicineId = sMedicine.Id
                                });
                            }

                            sMedicines.Add(sMedicine);
                            dImMestMedicines.Add(dImMestMedicine);
                        }
                        _mapper.Map(input, dImMestOld);

                        dImMestOld.ModifiedDate = dateNow;
                        dImMestOld.ModifiedBy = SessionExtensions.Login?.Id;
                    }

                    _dbContext.SMedicines.AddRange(sMedicines);
                    _dbContext.DImpMestMedicines.AddRange(dImMestMedicines);
                    _dbContext.DMedicineStocks.AddRange(dMedicineStocks);
                    _dbContext.SMedicinePricePolicies.AddRange(sMedicinePricePolicies);

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
        private async Task<ApiResult<DImpMestDto>> ImportFromSupplierValid(DImpMestDto input)
        {
            var result = new ApiResult<DImpMestDto>();

            try
            {
                var erros = new List<string>();

                var erroMasters = new List<string>();

                if (GuidHelper.IsNullOrEmpty(input.ImpStockId))
                    erroMasters.Add("Kho nhập");
                if (DatetimeHelper.IsNullOrEmpty(input.ImpTime))
                    erroMasters.Add("Ngày lập");
                if (DatetimeHelper.IsNullOrEmpty(input.InvTime))
                    erroMasters.Add("Ngày HĐ");
                if (GuidHelper.IsNullOrEmpty(input.SupplierId))
                    erroMasters.Add("Nhà cung cấp");

                if (erroMasters.Count > 0)
                    erros.Add(string.Format("{0} không được bỏ trống!", string.Join(", ", erroMasters)));

                if (!string.IsNullOrEmpty(input.Code))
                {
                    var any = _dbContext.DImpMests.Any(a => a.Id != input.Id && a.Code == input.Code);
                    if (any)
                        erros.Add(string.Format("Mã phiếu nhập [{0}] đã tồn tại trên hệ thống. Vui lòng kiểm tra lại!", input.Code));
                }

                if (input.DImpMestMedicines == null && input.DImpMestMedicines.Count == 0)
                    erros.Add("Không có thuốc nào được chọn trong danh sách!");

                foreach (var detail in input.DImpMestMedicines)
                {
                    var erroMedicines = new List<string>();

                    if (detail.ImpQuantity == 0)
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
        public async Task<ApiResult<DImpMestDto>> ImportFromAnotherStockGetById(Guid id)
        {
            var result = new ApiResult<DImpMestDto>();

            try
            {
                var dImpMestDto = _mapper.Map<DImpMestDto>(_dbContext.DImpMests.FirstOrDefault(d => d.Id == id));
                if (dImpMestDto != null)
                {
                    // Nhập từ kho khác
                    if (dImpMestDto.ImpExpMestTypeId == 3)
                    {
                        var dImpMestMedicineDtos = (from dImpMestMedicine in _dbContext.DImpMestMedicines
                                                    join sMedicine in _dbContext.SMedicines on dImpMestMedicine.MedicineId equals sMedicine.Id
                                                    where dImpMestMedicine.ImpMestId == id
                                                    select new DImpMestMedicineDto()
                                                    {
                                                        Id = id,
                                                        Code = sMedicine.Code,
                                                        HeInCode = sMedicine.HeInCode,
                                                        Name = sMedicine.Name,
                                                        MedicineId = dImpMestMedicine.MedicineId,
                                                        SortOrder = sMedicine.SortOrder,
                                                        MedicineLineId = sMedicine.MedicineLineId,
                                                        MedicineGroupId = sMedicine.MedicineGroupId,
                                                        MedicineTypeId = sMedicine.MedicineTypeId,
                                                        UnitId = sMedicine.UnitId,
                                                        Tutorial = sMedicine.Tutorial,
                                                        CountryId = sMedicine.CountryId,
                                                        ImpPrice = sMedicine.ImpPrice,
                                                        ImpQuantity = sMedicine.ImpQuantity,
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

        /// <summary>
        /// Lưu phiếu tạm
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<DImpMestDto>> ImportFromAnotherStockSaveAsDraft(DImpMestDto input)
        {
            input.ImpMestStatus = ImpMestStatusType.None;
            return await ImportFromAnotherStock(input);
        }

        /// <summary>
        /// Gửi yêu cầu
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<DImpMestDto>> ImportFromAnotherStockRequest(DImpMestDto input)
        {
            input.ImpMestStatus = ImpMestStatusType.Request;
            return await ImportFromAnotherStock(input);
        }

        /// <summary>
        /// Nhập kho
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ApiResult<DImpMestDto>> ImportFromAnotherStockStockIn(DImpMestDto input)
        {
            input.ImpMestStatus = ImpMestStatusType.ReceivedInStock;
            return await ImportFromSupplier(input);
        }

        /// <summary>
        /// Nhập thuốc từ kho khác
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private async Task<ApiResult<DImpMestDto>> ImportFromAnotherStock(DImpMestDto input)
        {
            var result = new ApiResult<DImpMestDto>();

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

                    input.ImpExpMestTypeId = 3;

                    var dImpMest = new DImpMest();
                    var dImMestMedicines = new List<DImpMestMedicine>();
                    var dMedicineStocks = new List<EntityFrameworkCore.Entities.Business.Pharmaceuticals.DMedicineStock>();

                    if (GuidHelper.IsNullOrEmpty(input.Id))
                    {
                        dImpMest = _mapper.Map<DImpMest>(input);
                        dImpMest.Id = id;
                        dImpMest.CreatedBy = SessionExtensions.Login?.Id;
                        dImpMest.CreatedDate = dateNow;

                        foreach (var dImMestMedicineDto in input.DImpMestMedicines)
                        {
                            var dImMestMedicine = _mapper.Map<DImpMestMedicine>(dImMestMedicineDto);
                            dImMestMedicine.Id = Guid.NewGuid();
                            dImMestMedicine.ImpMestId = id;

                            dImMestMedicines.Add(dImMestMedicine);
                        }

                        // Trạng thái nhập kho mới thêm vào thuốc trong kho
                        if (input.ImpMestStatus == ImpMestStatusType.ReceivedInStock)
                        {
                            dImpMest.StockImpTime = dateNow;
                            dImpMest.StockImpUserId = SessionExtensions.Login?.Id;

                            var sMedicineIds = input.DImpMestMedicines.Select(s => s.MedicineId).ToList();
                            if (sMedicineIds != null && sMedicineIds.Count > 0)
                            {
                                var dMedicineStockOlds = _dbContext.DMedicineStocks.Where(w => sMedicineIds.Contains(w.MedicineId) && w.StockId == dImpMest.ImpStockId).ToList();

                                foreach (var dImMestMedicineDto in input.DImpMestMedicines)
                                {
                                    // Nếu tồn tại thuốc trong kho thì cộng thêm vào tồn và khả dụng
                                    var dMedicineStock = dMedicineStockOlds?.FirstOrDefault(f => f.MedicineId == dImMestMedicineDto.MedicineId);
                                    if (dMedicineStock != null)
                                    {
                                        dMedicineStock.ModifiedBy = SessionExtensions.Login?.Id;
                                        dMedicineStock.ModifiedDate = dateNow;

                                        dMedicineStock.AvailableQuantity += dImMestMedicineDto.ImpQuantity.GetValueOrDefault();
                                        dMedicineStock.Quantity += dImMestMedicineDto.ImpQuantity.GetValueOrDefault();
                                    }
                                    else // Nếu chưa tồn tại thuốc trong kho thì thêm mới thuốc vào kho
                                    {
                                        dMedicineStocks.Add(new EntityFrameworkCore.Entities.Business.Pharmaceuticals.DMedicineStock()
                                        {
                                            Id = Guid.NewGuid(),
                                            CreatedDate = dateNow,
                                            CreatedBy = SessionExtensions.Login?.Id,
                                            AvailableQuantity = dImMestMedicineDto.ImpQuantity.GetValueOrDefault(),
                                            Quantity = dImMestMedicineDto.ImpQuantity.GetValueOrDefault(),
                                            StockId = input.ImpStockId,
                                            MedicineId = dImMestMedicineDto.MedicineId
                                        });
                                    }
                                }
                            }
                        }

                        _dbContext.DImpMests.Add(dImpMest);
                    }
                    else
                    {
                        dImpMest = _dbContext.DImpMests.FirstOrDefault(d => d.Id == input.Id);

                        // Xóa bản ghi cũ
                        var dImMestMedicineOlds = _dbContext.DImpMestMedicines.Where(s => s.ImpMestId == input.Id).ToList();

                        if (dImMestMedicineOlds != null)
                        {
                            _dbContext.DImpMestMedicines.RemoveRange(dImMestMedicineOlds);
                            //_dbContext.SaveChanges();
                        }

                        foreach (var dImMestMedicineDto in input.DImpMestMedicines)
                        {
                            var dImMestMedicine = _mapper.Map<DImpMestMedicine>(dImMestMedicineDto);
                            if (GuidHelper.IsNullOrEmpty(dImMestMedicine.Id))
                                dImMestMedicine.Id = Guid.NewGuid();
                            dImMestMedicine.ImpMestId = input.Id;

                            dImMestMedicines.Add(dImMestMedicine);
                        }

                        // Trạng thái nhập kho mới thêm vào thuốc trong kho
                        if (input.ImpMestStatus == ImpMestStatusType.ReceivedInStock)
                        {
                            input.StockImpTime = dateNow;
                            input.StockImpUserId = SessionExtensions.Login?.Id;

                            var sMedicineIds = input.DImpMestMedicines.Select(s => s.MedicineId).ToList();
                            if (sMedicineIds != null && sMedicineIds.Count > 0)
                            {
                                var dMedicineStockOlds = _dbContext.DMedicineStocks.Where(w => sMedicineIds.Contains(w.MedicineId) && w.StockId == dImpMest.ImpStockId).ToList();

                                foreach (var dImMestMedicineDto in input.DImpMestMedicines)
                                {
                                    // Nếu tồn tại thuốc trong kho thì cộng thêm vào tồn và khả dụng
                                    var dMedicineStock = dMedicineStockOlds?.FirstOrDefault(f => f.MedicineId == dImMestMedicineDto.MedicineId);
                                    if (dMedicineStock != null)
                                    {
                                        dMedicineStock.ModifiedBy = SessionExtensions.Login?.Id;
                                        dMedicineStock.ModifiedDate = dateNow;

                                        dMedicineStock.AvailableQuantity += dImMestMedicineDto.ImpQuantity.GetValueOrDefault();
                                        dMedicineStock.Quantity += dImMestMedicineDto.ImpQuantity.GetValueOrDefault();
                                    }
                                    else // Nếu chưa tồn tại thuốc trong kho thì thêm mới thuốc vào kho
                                    {
                                        dMedicineStocks.Add(new EntityFrameworkCore.Entities.Business.Pharmaceuticals.DMedicineStock()
                                        {
                                            Id = Guid.NewGuid(),
                                            CreatedDate = dateNow,
                                            CreatedBy = SessionExtensions.Login?.Id,
                                            AvailableQuantity = dImMestMedicineDto.ImpQuantity.GetValueOrDefault(),
                                            Quantity = dImMestMedicineDto.ImpQuantity.GetValueOrDefault(),
                                            StockId = input.ImpStockId,
                                            MedicineId = dImMestMedicineDto.MedicineId
                                        });
                                    }
                                }
                            }
                        }

                        _mapper.Map(input, dImpMest);
                        dImpMest.ModifiedDate = dateNow;
                        dImpMest.ModifiedBy = SessionExtensions.Login?.Id;

                        // Tạo phiếu xuất kho từ phiếu nhập kho từ kho khác
                        var dImpMestResultDto = await _dExpMestService.ImportFromAnotherStockCreateExpMest(dImpMest, dImMestMedicines);
                        if (!dImpMestResultDto.IsSuccessed)
                        {
                            result.IsSuccessed = false;
                            result.Message = dImpMestResultDto.Message;
                            transaction.Dispose();
                        }
                    }

                    _dbContext.DImpMestMedicines.AddRange(dImMestMedicines);
                    _dbContext.DMedicineStocks.AddRange(dMedicineStocks);

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

        private async Task<ApiResult<DImpMestDto>> ImportFromAnotherStockValid(DImpMestDto input)
        {
            var result = new ApiResult<DImpMestDto>();

            try
            {
                var erros = new List<string>();

                var erroMasters = new List<string>();

                if (GuidHelper.IsNullOrEmpty(input.ImpStockId))
                    erroMasters.Add("Kho nhập");
                if (GuidHelper.IsNullOrEmpty(input.ExpStockId))
                    erroMasters.Add("Kho Xuất");
                if (DatetimeHelper.IsNullOrEmpty(input.ImpTime))
                    erroMasters.Add("Ngày lập");
                if (GuidHelper.IsNullOrEmpty(input.ImpUserId))
                    erroMasters.Add("Người lập");

                if (erroMasters.Count > 0)
                    erros.Add(string.Format("{0} không được bỏ trống!", string.Join(", ", erroMasters)));

                if (input.DImpMestMedicines == null && input.DImpMestMedicines.Count == 0)
                    erros.Add("Không có thuốc nào được chọn trong danh sách!");

                foreach (var detail in input.DImpMestMedicines)
                {
                    var erroMedicines = new List<string>();

                    if (detail.ImpQuantity == 0)
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
                var medicineIds = input.DImpMestMedicines.Select(s => s.MedicineId).ToList();
                if (medicineIds != null && medicineIds.Count > 0)
                {
                    var medicineStocks = _dbContext.DMedicineStocks.Where(w => medicineIds.Contains(w.MedicineId) && w.StockId == input.ExpStockId).ToList();
                    if (medicineStocks != null)
                    {
                        foreach (var item in input.DImpMestMedicines)
                        {
                            var medicineStock = medicineStocks.FirstOrDefault(f => f.MedicineId == item.MedicineId);
                            if (medicineStock != null)
                            {
                                if (item.ImpQuantity > medicineStock.AvailableQuantity)
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
