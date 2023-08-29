using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Business.InOutStock;
using HIS.Dtos.Business.InOutStockMedicine;
using HIS.Dtos.Commons;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;
using System.Globalization;

namespace HIS.ApplicationService.Business.Pharmaceuticals.DExpMests
{
    public class DExpMestService : BaseSerivce, IDExpMestService
    {
        public DExpMestService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
          : base(dbContext, config, mapper) { }

        public async Task<ApiResultList<InOutStockDto>> GetByStocks(Guid stockId, string fromDate, string toDate)
        {
            var result = new ApiResultList<InOutStockDto>();

            try
            {
                DateTime fromDateTime = DateTime.ParseExact(fromDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);
                DateTime toDateTime = DateTime.ParseExact(toDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);

                result.Result = (from dExpMest in _dbContext.InOutStocks

                                 join imStock in _dbContext.SRooms on dExpMest.ImpStockId equals imStock.Id into imStockDefaults
                                 from imStockDefault in imStockDefaults.DefaultIfEmpty()

                                 join exStock in _dbContext.SRooms on dExpMest.ExpStockId equals exStock.Id into exStockDefaults
                                 from exStockDefault in exStockDefaults.DefaultIfEmpty()

                                 join impExpMestType in _dbContext.InOutStockTypes on dExpMest.InOutStockTypeId equals impExpMestType.Id into impExpMestTypeDefaults
                                 from impExpMestTypeDefault in impExpMestTypeDefaults.DefaultIfEmpty()

                                 select new InOutStockDto()
                                 {
                                     Id = dExpMest.Id,
                                     Code = dExpMest.Code,
                                     //ImpMestStatus = dExpMest.ImpMestStatus,
                                     //ExpMestStatus = dExpMest.ExpMestStatus,
                                     ImpStockId = dExpMest.ImpStockId,
                                     ImpStockCode = imStockDefault != null ? imStockDefault.Code : null,
                                     ImpStockName = imStockDefault != null ? imStockDefault.Name : null,
                                     ExpStockId = dExpMest.ExpStockId,
                                     ExpStockCode = exStockDefault != null ? exStockDefault.Code : null,
                                     ExpStockName = exStockDefault != null ? exStockDefault.Name : null,
                                     //ImpExpMestTypeId = dExpMest.ImpExpMestTypeId,
                                     ImpExpMestTypeName = impExpMestTypeDefault != null ? impExpMestTypeDefault.Name : null,
                                     ApproverUserId = dExpMest.ApproverUserId,
                                     //ExpTime = dExpMest.ExpTime.Value,
                                     //ExpUserId = dExpMest.ExpUserId,
                                     //StockExpUserId = dExpMest.StockExpUserId,
                                     //StockExpTime = dExpMest.StockExpTime,
                                     ApproverTime = dExpMest.ApproverTime,
                                     Description = dExpMest.Description,
                                     ReqRoomId = dExpMest.ReqRoomId,
                                     ReqDepartmentId = dExpMest.ReqDepartmentId,
                                     PatientRecordId = dExpMest.PatientRecordId,
                                     PatientId = dExpMest.PatientId,
                                     SupplierId = dExpMest.SupplierId,
                                     //ImpMestId = dExpMest.ImpMestId,
                                 })
                                 //.WhereIf(fromDateTime != (DateTime)default, w => w.ExpTime >= fromDateTime)
                                 //.WhereIf(toDateTime != (DateTime)default, w => w.ExpTime <= toDateTime)
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(stockId), w => w.ExpStockId == stockId)
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
        public async Task<ApiResult<InOutStockDto>> ExpFromAnotherStockGetById(Guid id)
        {
            var result = new ApiResult<InOutStockDto>();

            try
            {
                var dExpMestDto = _mapper.Map<InOutStockDto>(_dbContext.InOutStocks.FirstOrDefault(d => d.Id == id));
                if (dExpMestDto != null)
                {
                    dExpMestDto.InOutStockMedicine = (from dExpMestMedicine in _dbContext.InOutStockMedicines
                                                     join sMedicine in _dbContext.SMedicines on dExpMestMedicine.MedicineId equals sMedicine.Id

                                                     where dExpMestMedicine.InOutStockId == id

                                                     select new InOutStockMedicineDto()
                                                     {
                                                         Id = dExpMestMedicine.Id,
                                                         Code = sMedicine.Code,
                                                         HeInCode = sMedicine.HeInCode,
                                                         Name = sMedicine.Name,
                                                         SortOrder = dExpMestMedicine.SortOrder,
                                                         MedicineLineId = sMedicine.MedicineLineId,
                                                         MedicineGroupId = sMedicine.MedicineGroupId,
                                                         MedicineTypeId = sMedicine.MedicineTypeId,
                                                         UnitId = sMedicine.UnitId,
                                                         Tutorial = sMedicine.Tutorial,
                                                         CountryId = sMedicine.CountryId,
                                                         ImpPrice = dExpMestMedicine.ImpPrice,
                                                         ImpVatRate = dExpMestMedicine.ImpVatRate,
                                                         TaxRate = dExpMestMedicine.ImpTaxRate,
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
                                                         MedicineId = dExpMestMedicine.MedicineId,
                                                     }).ToList();
                }

                result.Result = dExpMestDto;
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
