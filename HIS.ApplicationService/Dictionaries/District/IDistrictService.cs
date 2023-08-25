using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.Department;
using HIS.Dtos.Dictionaries.District;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.District
{
    public interface IDistrictService : IBaseDictionaryService<DistrictDto, GetAllDistrictInput>
    {
    }
}
