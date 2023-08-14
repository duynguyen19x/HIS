using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Business.DImMest;
using HIS.Dtos.Business.DMedicineStock;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Pharmaceuticals.DMedicineStock
{
    public class DMedicineStockService : BaseSerivce, IDMedicineStockService
    {
        public DMedicineStockService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
          : base(dbContext, config, mapper) { }

        public async Task<ApiResultList<DMedicineStockDto>> GetAll(GetAllDMedicineStockInput input)
        {
            var result = new ApiResultList<DMedicineStockDto>();

            try
            {
                result.Result = (from mediStock in _dbContext.DMedicineStocks
                                 join stock in _dbContext.SRooms on mediStock.StockId equals stock.Id
                                 join medicine in _dbContext.SMedicines on mediStock.MedicineId equals medicine.Id
                                 select new DMedicineStockDto()
                                 {
                                     Id = mediStock.Id,
                                     MedicineId = mediStock.MedicineId,
                                     StockId = mediStock.StockId,
                                     AvailableQuantity = mediStock.AvailableQuantity,
                                     Quantity = mediStock.Quantity,

                                     MedicineCode = medicine.Code,
                                     MedicineName = medicine.Name,
                                     StockCode = stock.Code,
                                     StockName = stock.Name,
                                 })
                                 .WhereIf(!GuidHelper.IsNullOrEmpty( input.StockIdFilter), w => w.StockId == input.StockIdFilter)
                                 .WhereIf(!GuidHelper.IsNullOrEmpty( input.MedicineIdFilter), w => w.MedicineId == input.MedicineIdFilter)
                                 .OrderBy(o => o.StockCode).ToList();

                result.TotalCount = result.Result.Count;
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
