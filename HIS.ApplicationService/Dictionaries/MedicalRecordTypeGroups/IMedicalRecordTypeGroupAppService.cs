using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.MedicalRecordTypeGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.MedicalRecordTypeGroups
{
    public interface IMedicalRecordTypeGroupAppService : IBaseCrudAppService<MedicalRecordTypeGroupDto, int, GetAllMedicalRecordTypeGroupInput>
    {
    }
}
