using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Ward;

namespace HIS.ApplicationService.Dictionaries.Wards
{
    public interface IWardAppService : IAppService
    {
        Task<ResultDto<WardDto>> CreateOrEdit(WardDto input);
        Task<ResultDto<WardDto>> Delete(Guid id);
        Task<PagedResultDto<WardDto>> GetAll(GetAllWardInput input);
        Task<ResultDto<WardDto>> GetById(Guid id);
    }
}
