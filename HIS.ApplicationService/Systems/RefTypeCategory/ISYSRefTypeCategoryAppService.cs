using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Systems.RefTypeCategory;

namespace HIS.ApplicationService.Systems.RefTypeCategory
{
    public interface ISYSRefTypeCategoryAppService 
    {
        Task<PagedResultDto<SYSRefTypeCategoryDto>> GetAllAsync(GetAllSYSRefTypeCategoryInputDto input);

        Task<ResultDto<SYSRefTypeCategoryDto>> GetAsync(int id);

        Task<ResultDto<SYSRefTypeCategoryDto>> CreateOrUpdateAsync(SYSRefTypeCategoryDto input);

        Task<ResultDto<SYSRefTypeCategoryDto>> DeleteAsync(int id);
    }
}
