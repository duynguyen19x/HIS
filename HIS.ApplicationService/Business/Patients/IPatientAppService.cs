using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Patients
{
    public interface IPatientAppService : IBaseAppService
    {
        Task<ResultDto<PatientDto>> CreateOrEdit(PatientDto input);
        Task<ResultDto<PatientDto>> Delete(Guid id);
        Task<PagedResultDto<PatientDto>> GetAll(PatientRequestDto input);
        Task<ResultDto<PatientDto>> GetById(Guid id);
    }
}
