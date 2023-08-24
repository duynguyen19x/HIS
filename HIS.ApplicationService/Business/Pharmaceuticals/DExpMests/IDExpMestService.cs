using HIS.Dtos.Business.DExpMest;
using HIS.Dtos.Commons;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.DExpMests;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.DImpMests;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Pharmaceuticals.DExpMests
{
    public interface IDExpMestService
    {
        public Task<ApiResultList<DExpMestDto>> GetByStocks(Guid stockId, string fromDate, string toDate);

        public Task<ApiResult<DExpMestDto>> ExpFromAnotherStockGetById(Guid id);
    }
}
