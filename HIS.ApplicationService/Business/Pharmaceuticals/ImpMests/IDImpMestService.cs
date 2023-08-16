using HIS.Dtos.Business.DImMest;
using HIS.Dtos.Business.Patient;
using HIS.Dtos.Commons;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Pharmaceuticals.ImpMests
{
    public interface IDImpMestService
    {
        public Task<ApiResultList<DImpMestDto>> GetByStock(Guid stockId, string fromDate, string toDate);

        public Task<ApiResult<DImpMestDto>> ImportFromSupplierSaveAsDraft(DImpMestDto input);
        public Task<ApiResult<DImpMestDto>> ImportFromSupplierStockIn(DImpMestDto input);
        public Task<ApiResult<bool>> ImportFromSupplierCanceled(Guid id);

        public Task<ApiResult<DImpMestDto>> GetById(Guid id);
    }
}
