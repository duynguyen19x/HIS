using HIS.Dtos.Business.DExpMest;
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
        public Task<ApiResult<DExpMest>> ImportFromAnotherStockCreateExpMest(DImpMest dImpMest, IList<DImpMestMedicine> dImpMestMedicines);
    }
}
