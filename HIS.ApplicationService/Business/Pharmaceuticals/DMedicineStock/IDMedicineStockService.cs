using HIS.Dtos.Business.DMedicineStock;
using HIS.Dtos.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Pharmaceuticals.DMedicineStock
{
    public interface IDMedicineStockService 
    {
        Task<ApiResultList<DMedicineStockDto>> GetAll(GetAllDMedicineStockInput input);
    }
}
