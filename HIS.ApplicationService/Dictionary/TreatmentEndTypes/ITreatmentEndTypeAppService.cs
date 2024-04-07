using HIS.ApplicationService.Dictionary.TransferReasons.Dto;
using HIS.ApplicationService.Dictionary.TreatmentEndTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.TreatmentEndTypes
{
    public interface ITreatmentEndTypeAppService : IAppService
    {
        Task<PagedResultDto<TreatmentEndTypeDto>> GetAll(GetAllTreatmentEndTypeInputDto input);
    }
}
