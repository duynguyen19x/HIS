using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Business.DImpMest;
using HIS.Dtos.Commons;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;
using System.Globalization;

namespace HIS.ApplicationService.Business.Pharmaceuticals.DExpMests
{
    public class DExpMestService : BaseSerivce, IDExpMestService
    {
        public DExpMestService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
          : base(dbContext, config, mapper) { }

        public async Task<ApiResultList<DImpMestDto>> GetByStock(Guid stockId, string fromDate, string toDate)
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
    }
}
