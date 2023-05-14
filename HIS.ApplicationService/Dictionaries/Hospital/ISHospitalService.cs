using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.Hospital;
using HIS.Dtos.Dictionaries.Career;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Hospital
{
    public interface ISHospitalService : IBaseDictionaryService<SHospitalDto, GetAllSHospitalInput>
    {
    }
}
