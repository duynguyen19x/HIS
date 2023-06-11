using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.ServiceGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.ServiceGroup
{
    public interface IServiceGroupService : IBaseDictionaryService<SServiceGroupDto, GetAllSServiceGroupInput>
    {
    }
}
