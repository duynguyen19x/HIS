using HIS.ApplicationService.Dictionary.ReceptionObjectTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Ward;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.ReceptionObjectTypes
{
    public interface IReceptionObjectTypeAppService : IAppService
    {
        Task<PagedResultDto<ReceptionObjectTypeDto>> GetAll(GetAllReceptionObjectTypeInputDto input);
    }
}
