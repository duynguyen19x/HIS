using HIS.ApplicationService.System.Options.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.System.Options
{
    public interface IOptionAppService : IAppService
    {
        Task<PagedResultDto<OptionDto>> GetAllAsync(GetAllOptionInputDto input);

        Task<ResultDto<OptionDto>> GetAsync(Guid id);

        Task<ResultDto<OptionDto>> CreateOrUpdateAsync(OptionDto input);

        Task<ResultDto<OptionDto>> DeleteAsync(Guid id);
    }
}
