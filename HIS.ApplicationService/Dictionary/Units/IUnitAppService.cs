using HIS.ApplicationService.Dictionary.Units.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Units
{
    public interface IUnitAppService : IAppService
    {
        Task<ResultDto<UnitDto>> CreateOrEdit(UnitDto input);
        Task<ResultDto<UnitDto>> Delete(Guid id);
        Task<PagedResultDto<UnitDto>> GetAll(GetAllUnitInput input);
        Task<ResultDto<UnitDto>> GetById(Guid id);
    } 
}
