using HIS.ApplicationService.Dictionary.Icds.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Icds
{
    public interface IIcdAppService : IAppService
    {
        Task<ResultDto<IcdDto>> CreateOrEdit(IcdDto input);
        Task<ResultDto<IcdDto>> Delete(Guid id);
        Task<PagedResultDto<IcdDto>> GetAll(GetAllIcdInput input);
        Task<ResultDto<IcdDto>> GetById(Guid id);
    }
}
