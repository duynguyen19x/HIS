using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.Department;
using HIS.Dtos.Dictionaries.Province;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Province
{
    public interface IProvinceService : IBaseDictionaryService<ProvinceDto, GetAllProvinceInput>
    {
    }
}
