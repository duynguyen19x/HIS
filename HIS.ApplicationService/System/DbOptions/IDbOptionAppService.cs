using HIS.ApplicationService.Dictionary.DepartmentTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Systems.DbOption;

namespace HIS.ApplicationService.Systems.DbOptions
{
    public interface IDbOptionAppService : IAppService
    {
        Task<ResultDto<DbOptionDto>> CreateOrEdit(DbOptionDto input);
        Task<ResultDto<DbOptionDto>> Delete(Guid id);
        Task<PagedResultDto<DbOptionDto>> GetAll(GetAllDbOptionInput input);
        Task<ResultDto<DbOptionDto>> GetById(Guid id);

        Task<ResultDto<OptionValueDto>> GetMapOptions();
    }
}
