using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.ChapterICD10;

namespace HIS.ApplicationService.Dictionaries.ChapterICD10
{
    public interface IChapterIcdService : IAppService
    {
        Task<ResultDto<ChapterIcdDto>> CreateOrEdit(ChapterIcdDto input);
        Task<ResultDto<ChapterIcdDto>> Delete(Guid id);
        Task<PagedResultDto<ChapterIcdDto>> GetAll(GetAllChapterIcdInput input);
        Task<ResultDto<ChapterIcdDto>> GetById(Guid id);
    }
}
