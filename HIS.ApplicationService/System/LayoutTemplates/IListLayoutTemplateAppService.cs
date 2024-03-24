using HIS.ApplicationService.Systems.LayoutTemplates.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.System.LayoutTemplates
{
    public interface IListLayoutTemplateAppService : IAppService
    {
        Task<PagedResultDto<ListLayoutTemplateDto>> GetAllAsync(GetAllSYSLayoutTemplateInputDto input);

        Task<ResultDto<ListLayoutTemplateDto>> GetAsync(Guid id);

        Task<ResultDto<ListLayoutTemplateDto>> CreateOrUpdateAsync(ListLayoutTemplateDto input);

        Task<ResultDto<ListLayoutTemplateDto>> DeleteAsync(Guid id);
    }
}
