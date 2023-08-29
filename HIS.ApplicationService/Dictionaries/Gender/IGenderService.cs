using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.Gender;
using HIS.Dtos.Dictionaries.Hospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Gender
{
    public interface IGenderService : IBaseDictionaryService<GenderDto, GetAllGenderInput>
    {
    }
}
