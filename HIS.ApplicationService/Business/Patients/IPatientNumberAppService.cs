using HIS.ApplicationService.Business.Patients.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Patients
{
    public interface IPatientNumberAppService : IAppService
    {
        Task<ResultDto<PatientNumberDto>> CreateLastNumber(DateTime patientNumberDate);
        //Task<ResultDto<PatientNumberDto>> Get(Guid id);
    }
}
