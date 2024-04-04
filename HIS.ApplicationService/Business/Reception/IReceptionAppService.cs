using HIS.ApplicationService.Business.Reception.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Reception
{
    /// <summary>
    /// Phòng tiếp đón.
    /// </summary>
    public interface IReceptionAppService : IAppService
    {
        Task<PagedResultDto<ReceptionDto>> GetAll(GetAllReceptionInputDto input);
    }
}
