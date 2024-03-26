using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.RelativeTypes;

namespace HIS.ApplicationService.Dictionaries.RelativeTypes
{
    public interface IRelativeTypeAppService : IAppService
    {
        Task<ResultDto<RelativeTypeDto>> CreateOrEdit(RelativeTypeDto input);
        Task<ResultDto<RelativeTypeDto>> Delete(Guid id);
        Task<PagedResultDto<RelativeTypeDto>> GetAll(GetAllRelativeTypeInputDto input);
        Task<ResultDto<RelativeTypeDto>> GetById(Guid id);
    }
}
