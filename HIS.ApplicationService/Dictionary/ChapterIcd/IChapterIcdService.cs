using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.ChapterICD10;

namespace HIS.ApplicationService.Dictionaries.ChapterICD10
{
    public interface IChapterIcdService : IBaseCrudAppService<ChapterIcdDto, Guid?, GetAllChapterIcdInput>
    {
    }
}
