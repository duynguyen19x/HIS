using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.PatientObjectTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.PatientObjectTypes
{
    public interface IPatientObjectTypeAppService : IBaseCrudAppService<PatientObjectTypeDto, int, GetAllPatientObjectTypeInput>
    {
    }
}
