using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.PatientTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.PatientTypes
{
    public interface IPatientTypeAppService : IBaseCrudAppService<PatientTypeDto, int, GetAllPatientTypeInput>
    {
    }
}
