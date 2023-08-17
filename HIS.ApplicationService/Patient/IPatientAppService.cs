using HIS.Application.Core.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Patient;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Patient
{
    public interface IPatientAppService : IBaseAppService
    {
        /// <summary>
        /// Lấy danh sách bệnh nhân.
        /// </summary>
        Task<PagedResultDto<PatientDto>> GetAll(GetAllPatientInputDto input);

        /// <summary>
        /// Lấy thông tin bệnh nhân và thông tin điều trị gần nhất theo mã bệnh nhân.
        /// </summary>
        Task<ApiResult<PatientDto>> GetById(Guid id);

        /// <summary>
        /// Lấy thông tin bệnh nhân theo mã hồ sơ bệnh án.
        /// </summary>
        Task<ApiResult<PatientDto>> GetByTreatmentId(Guid id);
    }
}
