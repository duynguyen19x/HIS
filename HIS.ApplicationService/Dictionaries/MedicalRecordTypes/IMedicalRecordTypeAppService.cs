using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.MedicalRecordTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.MedicalRecordTypes
{
    public interface IMedicalRecordTypeAppService : IBaseCrudAppService<MedicalRecordTypeDto, int, GetAllMedicalRecordTypeInput>
    {
    }
}
