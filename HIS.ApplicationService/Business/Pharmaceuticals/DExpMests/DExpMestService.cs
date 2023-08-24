using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Business.DExpMest;
using HIS.Dtos.Business.DExpMestMedicine;
using HIS.Dtos.Business.DImMestMedicine;
using HIS.Dtos.Business.DImpMest;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicinePricePolicy;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.DExpMests;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.DImpMests;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using HIS.Utilities.Sections;
using Microsoft.Extensions.Configuration;
using System.Globalization;
using System.Linq;

namespace HIS.ApplicationService.Business.Pharmaceuticals.DExpMests
{
    public class DExpMestService : BaseSerivce, IDExpMestService
    {
        public DExpMestService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
          : base(dbContext, config, mapper) { }

        public async Task<ApiResultList<DExpMestDto>> GetByStocks(Guid stockId, string fromDate, string toDate)
        {
            var result = new ApiResultList<DExpMestDto>();

            try
            {
                DateTime fromDateTime = DateTime.ParseExact(fromDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);
                DateTime toDateTime = DateTime.ParseExact(toDate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None);

                result.Result = (from dExpMest in _dbContext.DExpMests

                                 join imStock in _dbContext.SRooms on dExpMest.ImpStockId equals imStock.Id into imStockDefaults
                                 from imStockDefault in imStockDefaults.DefaultIfEmpty()

                                 join exStock in _dbContext.SRooms on dExpMest.ExpStockId equals exStock.Id into exStockDefaults
                                 from exStockDefault in exStockDefaults.DefaultIfEmpty()

                                 join impExpMestType in _dbContext.DImpExpMestTypes on dExpMest.ImpExpMestTypeId equals impExpMestType.Id into impExpMestTypeDefaults
                                 from impExpMestTypeDefault in impExpMestTypeDefaults.DefaultIfEmpty()

                                 select new DExpMestDto()
                                 {
                                     Id = dExpMest.Id,
                                     Code = dExpMest.Code,
                                     ImpMestStatus = dExpMest.ImpMestStatus,
                                     ExpMestStatus = dExpMest.ExpMestStatus,
                                     ImpStockId = dExpMest.ImpStockId,
                                     ImpStockCode = imStockDefault != null ? imStockDefault.Code : null,
                                     ImpStockName = imStockDefault != null ? imStockDefault.Name : null,
                                     ExpStockId = dExpMest.ExpStockId,
                                     ExpStockCode = exStockDefault != null ? exStockDefault.Code : null,
                                     ExpStockName = exStockDefault != null ? exStockDefault.Name : null,
                                     ImpExpMestTypeId = dExpMest.ImpExpMestTypeId,
                                     ImpExpMestTypeName = impExpMestTypeDefault != null ? impExpMestTypeDefault.Name : null,
                                     ApproverUserId = dExpMest.ApproverUserId,
                                     ExpTime = dExpMest.ExpTime.Value,
                                     ExpUserId = dExpMest.ExpUserId,
                                     StockExpUserId = dExpMest.StockExpUserId,
                                     StockExpTime = dExpMest.StockExpTime,
                                     ApproverTime = dExpMest.ApproverTime,
                                     Description = dExpMest.Description,
                                     ReqRoomId = dExpMest.ReqRoomId,
                                     ReqDepartmentId = dExpMest.ReqDepartmentId,
                                     PatientRecordId = dExpMest.PatientRecordId,
                                     PatientId = dExpMest.PatientId,
                                     SupplierId = dExpMest.SupplierId,
                                     ImpMestId = dExpMest.ImpMestId,
                                 })
                                 .WhereIf(fromDateTime != (DateTime)default, w => w.ExpTime >= fromDateTime)
                                 .WhereIf(toDateTime != (DateTime)default, w => w.ExpTime <= toDateTime)
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
        public async Task<ApiResult<DExpMestDto>> ExpFromAnotherStockGetById(Guid id)
        {
            var result = new ApiResult<DExpMestDto>();

            try
            {
                var dExpMestDto = _mapper.Map<DExpMestDto>(_dbContext.DImpMests.FirstOrDefault(d => d.Id == id));
                if (dExpMestDto != null)
                {
                    dExpMestDto.DExpMestMedicines = (from dExpMestMedicine in _dbContext.DExpMestMedicines
                                                     join sMedicine in _dbContext.SMedicines on dExpMestMedicine.MedicineId equals sMedicine.Id

                                                     where dExpMestMedicine.ExpMestId == id

                                                     select new DExpMestMedicineDto()
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
                                                         ExpQuantity = dExpMestMedicine.ExpQuantity,
                                                         ImpVatRate = dExpMestMedicine.ImpVatRate,
                                                         TaxRate = dExpMestMedicine.TaxRate,
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
                                                         ExpMestId = dExpMestMedicine.ExpMestId,
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
