using HIS.ApplicationService.Base;
using HIS.Dtos.Business.Patient;
using HIS.Dtos.Dictionaries.Branch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Patient
{
    public interface ISPatientService : IBaseDictionaryService<SPatientDto, GetAllSPatientInput>
    {
    }
}
