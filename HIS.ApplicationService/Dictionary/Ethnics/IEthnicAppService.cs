using HIS.ApplicationService.Dictionary.Ethnics.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Ethnics
{
    public interface IEthnicAppService : IAppService
    {
        Task<ResultDto<EthnicDto>> CreateOrUpdateAsync(EthnicDto input);

        Task<ResultDto<EthnicDto>> DeleteAsync(Guid id);

        Task<PagedResultDto<EthnicDto>> GetAllAsync(GetAllEthnicInputDto input);

        Task<ResultDto<EthnicDto>> GetAsync(Guid id);
    }
}
