using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.Country;
using HIS.Dtos.Dictionaries.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Country
{
    public interface ICountryService : IBaseDictionaryService<CountryDto, GetAllCountryInput>
    {
    }
}
