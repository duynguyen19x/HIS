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
    public interface IPatientOrderAppService : IAppService
    {
        Task<ResultDto<PatientNumberDto>> CreateLastOrder(DateTime patientOrderDate);
    }
}
