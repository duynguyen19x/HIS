using HIS.ApplicationService.Dictionary.Ethnicities.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Ethnicities
{
    public interface IEthnicityAppService : IAppService
    {
        Task<ResultDto<EthnicityDto>> CreateOrUpdateAsync(EthnicityDto input);

        Task<ResultDto<EthnicityDto>> DeleteAsync(Guid id);

        Task<PagedResultDto<EthnicityDto>> GetAllAsync(GetAllEthnicityInputDto input);

        Task<ResultDto<EthnicityDto>> GetAsync(Guid id);
    }
}
