using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Business.DExpMest;
using HIS.Dtos.Business.DImpMest;
using HIS.Dtos.Commons;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.DExpMests;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.DImpMests;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using HIS.Utilities.Sections;
using Microsoft.Extensions.Configuration;
using System.Globalization;

namespace HIS.ApplicationService.Business.Pharmaceuticals.DExpMests
{
    public class DExpMestService : BaseSerivce, IDExpMestService
    {
        public DExpMestService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
          : base(dbContext, config, mapper) { }

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
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(stockId), w => w.ImpStockId == stockId || w.ExpStockId == stockId)
                                 .ToList();
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }


            return await Task.FromResult(result);
        }

        #region Tạo phiếu xuất của phiếu Nhập từ kho khác
        public async Task<ApiResult<DExpMest>> ImportFromAnotherStockCreateExpMest(DImpMest dImpMest, IList<DImpMestMedicine> dImpMestMedicines)
        {
            var result = new ApiResult<DExpMest>();


            try
            {
                var dExpMest = new DExpMest();
                var dExpMestMedicines = new List<DExpMestMedicine>();

                if (GuidHelper.IsNullOrEmpty(dImpMest.ExpMestId))
                {
                    dExpMest = _mapper.Map<DExpMest>(dImpMest);

                    dExpMest.Id = Guid.NewGuid();
                    dExpMest.ExpTime = dImpMest.ImpTime;
                    dExpMest.ExpUserId = SessionExtensions.Login?.Id;

                    //var dExpMestMedicines = _mapper.Map<IList<DExpMestMedicine>>(dImpMestMedicines);
                    foreach (var dImpMestMedicine in dImpMestMedicines)
                    {
                        var dExpMestMedicine = _mapper.Map<DExpMestMedicine>(dImpMestMedicine);

                        dExpMestMedicine.Id = Guid.NewGuid();
                        dExpMestMedicine.ExpMestId = dExpMest.Id;
                        dExpMestMedicine.ExpQuantity = dImpMestMedicine.ImpQuantity;

                        dExpMestMedicines.Add(dExpMestMedicine);
                    }

                    _dbContext.DExpMests.Add(dExpMest);
                }
                else
                {
                    dExpMest = _dbContext.DExpMests.FirstOrDefault(f => f.Id == dImpMest.ExpMestId);
                    if (dExpMest != null)
                    {
                        var dExpMestMedicineOlds = _dbContext.DExpMestMedicines.Where(w => w.ExpMestId == dExpMest.Id).ToList();
                        if (dExpMestMedicineOlds != null && dExpMestMedicineOlds.Count > 0)
                        {
                            var medicineIds = dExpMestMedicineOlds.Select(s => s.MedicineId).ToList();
                            var dMeicineStocks = _dbContext.DMedicineStocks.Where(w => medicineIds.Contains(w.MedicineId) && w.StockId == dExpMest.ExpStockId).ToList();
                            foreach (var dMeicineStock in dMeicineStocks)
                            {
                                var dExpMestMedicineOld = dExpMestMedicineOlds.FirstOrDefault(f => f.MedicineId == dMeicineStock.MedicineId);
                                if (dExpMestMedicineOld != null)
                                {
                                    dMeicineStock.AvailableQuantity += dExpMestMedicineOld.ExpQuantity.GetValueOrDefault(); // Cộng số lượng khả dụng ở phiếu cũ vào kho
                                }
                            }

                            _dbContext.DMedicineStocks.RemoveRange(dMeicineStocks);
                        }

                        // Thêm chi tiết xuất thuốc
                        foreach (var dImpMestMedicine in dImpMestMedicines)
                        {
                            var dExpMestMedicine = _mapper.Map<DExpMestMedicine>(dImpMestMedicine);

                            dExpMestMedicine.Id = Guid.NewGuid();
                            dExpMestMedicine.ExpMestId = dExpMest.Id;
                            dExpMestMedicine.ExpQuantity = dImpMestMedicine.ImpQuantity;

                            dExpMestMedicines.Add(dExpMestMedicine);
                        }

                        // Trừ khả dụng của phiếu xuất mới
                        if (dExpMestMedicines.Count > 0)
                        {
                            var medicineIds = dExpMestMedicines.Select(s => s.MedicineId).ToList();
                            var dMeicineStocks = _dbContext.DMedicineStocks.Where(w => medicineIds.Contains(w.MedicineId) && w.StockId == dExpMest.ExpStockId).ToList();

                            foreach (var dMeicineStock in dMeicineStocks)
                            {
                                var dExpMestMedicine = dExpMestMedicines.FirstOrDefault(f => f.MedicineId == dMeicineStock.MedicineId);
                                if (dExpMestMedicine != null)
                                {
                                    dMeicineStock.AvailableQuantity -= dExpMestMedicine.ExpQuantity.GetValueOrDefault();
                                }
                            }
                        }

                        dExpMest.ImpMestStatus = dImpMest.ImpMestStatus;
                        dExpMest.ExpMestStatus = Utilities.Enums.EmpMestStatusType.None;
                    }
                }

                _dbContext.DExpMestMedicines.AddRange(dExpMestMedicines);
                _dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.IsSuccessed = false;
            }

            return await Task.FromResult(result);
        }
        #endregion
    }
}
