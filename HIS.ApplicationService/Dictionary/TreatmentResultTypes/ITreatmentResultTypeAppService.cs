using HIS.ApplicationService.Dictionary.TreatmentEndTypes.Dto;
using HIS.ApplicationService.Dictionary.TreatmentResultTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.TreatmentResultTypes
{
    public interface ITreatmentResultTypeAppService : IAppService
    {
        Task<PagedResultDto<TreatmentResultTypeDto>> GetAll(GetAllTreatmentResultTypeInputDto input);
    }
}
