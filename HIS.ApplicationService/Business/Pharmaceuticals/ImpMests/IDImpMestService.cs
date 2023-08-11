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
        public Task<ApiResult<DImpMestDto>> CreateOrEdit(DImpMestDto input);
        public Task<ApiResultList<DImpMestDto>> GetByStock(Guid stockId, string fromDate, string toDate);
    }
}
