using HIS.Dtos.Business.DImMest;
using HIS.Dtos.Business.Patient;
using HIS.Dtos.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Pharmaceuticals.ImpMests
{
    public interface IDImpMestService : IBaseService<DImpMestDto, GetAllDImpMestInput, Guid>
    {
        public Task<ApiResultList<DImpMestDto>> GetByStock(Guid stockId, string fromDate, string toDate);
    }
}
