using HIS.Application.Core.Services;
using HIS.ApplicationService.Dictionary.Careers.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Careers
{
    public interface ICareerAppService : IAppService 
    {
        Task<ResultDto<CareerDto>> CreateOrUpdateAsync(CareerDto input);
        Task<ResultDto<CareerDto>> DeleteAsync(Guid id);
        Task<PagedResultDto<CareerDto>> GetAllAsync(GetAllCareerInput input);
        Task<ResultDto<CareerDto>> GetAsync(Guid id);
    }
}
