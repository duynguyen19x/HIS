using HIS.Application.Core.Services;
using HIS.Dtos.Business.PatientRecords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.PatientRecords
{
    public interface IPatientRecordAppService : IBaseCrudAppService<PatientRecordDto, Guid, PatientRecordRequestDto>
    {
    }
}
