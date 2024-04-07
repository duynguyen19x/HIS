using HIS.ApplicationService.Dictionary.RoomTypes.Dto;
using HIS.ApplicationService.Dictionary.TransferForms.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.TransferForms
{
    public interface ITransferFormAppService : IAppService
    {
        Task<PagedResultDto<TransferFormDto>> GetAll(GetAllTransferFormInputDto input);
    }
}
