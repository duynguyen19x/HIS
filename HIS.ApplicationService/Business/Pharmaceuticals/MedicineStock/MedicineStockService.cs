using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Business.InOutStock;
using HIS.Dtos.Business.MedicineStock;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Medicine;
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

namespace HIS.ApplicationService.Business.Pharmaceuticals.MedicineStock
{
    public class MedicineStockService : BaseSerivce, IMedicineStockService
    {
        public MedicineStockService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
          : base(dbContext, config, mapper) { }

        public async Task<ApiResultList<MedicineStockDto>> GetAll(GetAllMedicineStockInput input)
        {
            var result = new ApiResultList<MedicineStockDto>();

            try
            {
                result.Result = (from mediStock in _dbContext.MedicineStocks
                                 join stock in _dbContext.Rooms on mediStock.StockId equals stock.Id
                                 join medicine in _dbContext.Medicines on mediStock.MedicineId equals medicine.Id
                                 select new MedicineStockDto()
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

        public async Task<ApiResultList<MedicineStockDto>> GetMedicineByStocks(Guid stockId)
        {
            var result = new ApiResultList<MedicineStockDto>();

            try
            {
                result.Result = (from dMedicineStock in _dbContext.MedicineStocks
                                 join sMedicine in _dbContext.Medicines on dMedicineStock.MedicineId equals sMedicine.Id

                                 where dMedicineStock.IsDeleted == false && dMedicineStock.AvailableQuantity > 0

                                 select new MedicineStockDto()
                                 {
                                     Id = dMedicineStock.Id,
                                     MedicineCode = sMedicine.Code,
                                     MedicineName = sMedicine.Name,
                                     StockId = dMedicineStock.StockId,
                                     MedicineId = dMedicineStock.MedicineId,
                                     Quantity = dMedicineStock.Quantity,
                                     AvailableQuantity = dMedicineStock.AvailableQuantity,
                                     SMedicine = _mapper.Map<MedicineDto>(sMedicine)
                                 }).ToList();
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
