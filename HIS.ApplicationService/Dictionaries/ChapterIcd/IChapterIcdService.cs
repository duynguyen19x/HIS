using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.ChapterICD10;
using HIS.Dtos.Dictionaries.ServiceUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.ChapterICD10
{
    public interface IChapterIcdService : IBaseDictionaryService<ChapterIcdDto, GetAllChapterIcdInput>
    {
    }
}
