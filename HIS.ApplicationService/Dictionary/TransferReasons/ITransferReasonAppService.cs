using HIS.ApplicationService.Dictionary.TransferReasons.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.TransferReasons
{
    public interface ITransferReasonAppService : IAppService
    {
        Task<PagedResultDto<TransferReasonDto>> GetAll(GetAllTransferReasonInputDto input);
    }
}
