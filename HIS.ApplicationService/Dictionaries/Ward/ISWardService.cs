using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.Province;
using HIS.Dtos.Dictionaries.Ward;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Ward
{
    public interface ISWardService : IBaseDictionaryService<SWardDto, GetAllSWardInput>
    {
    }
}
