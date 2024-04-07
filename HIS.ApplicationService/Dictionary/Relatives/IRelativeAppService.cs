using HIS.ApplicationService.Dictionary.RelativeTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.RelativeTypes
{
    public interface IRelativeAppService : IAppService
    {
        Task<ResultDto<RelativeDto>> CreateOrEdit(RelativeDto input);

        Task<ResultDto<RelativeDto>> Delete(Guid id);

        Task<PagedResultDto<RelativeDto>> GetAll(GetAllRelativeInputDto input);

        Task<ResultDto<RelativeDto>> GetById(Guid id);
    }
}
