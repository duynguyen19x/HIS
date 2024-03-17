using HIS.Application.Core.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Systems.DbOption;

namespace HIS.ApplicationService.Systems.DbOptions
{
    public interface IDbOptionAppService : IBaseCrudAppService<DbOptionDto, Guid?, GetAllDbOptionInput>
    {
        Task<ResultDto<OptionValueDto>> GetMapOptions();
    }
}
