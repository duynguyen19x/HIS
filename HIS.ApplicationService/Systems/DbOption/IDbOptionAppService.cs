using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.ChapterICD10;
using HIS.Dtos.Dictionaries.ServiceUnit;
using HIS.Dtos.Systems.DbOption;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.DbOption
{
    public interface IDbOptionAppService : IBaseDictionaryService<DbOptionDto, GetAllDbOptionInput>
    {
        Task<ApiResult<OptionValueDto>> GetMapOptions();

    }
}
