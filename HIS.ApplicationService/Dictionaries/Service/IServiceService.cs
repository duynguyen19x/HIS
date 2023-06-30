using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.ExecutionRoom;
using HIS.Dtos.Dictionaries.Service;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Service
{
    public interface IServiceService : IBaseDictionaryService<SServiceDto, GetAllSServiceInput>
    {
        Task<ApiResult<IList<SExecutionRoomDto>>> GetExecutionRoomByGroupHeIn(Guid serviceGroupHeInId);
    }
}
