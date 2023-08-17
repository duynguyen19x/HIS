using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Patient;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Patient
{
    public class PatientAppService : BaseAppService, IPatientAppService
    {
        public PatientAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async Task<PagedResultDto<PatientDto>> GetAll(GetAllPatientInputDto input)
        {
            return await new Task<PagedResultDto<PatientDto>>(null);
        }

        /// <summary>
        /// Lấy thông tin bệnh nhân có hồ sơ bệnh án gần nhất.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ApiResult<PatientDto>> GetById(Guid id)
        {
            return await new Task<ApiResult<PatientDto>>(null);
        }

        /// <summary>
        /// Lấy thông tin bệnh nhân theo hồ so bệnh án.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ApiResult<PatientDto>> GetByTreatmentId(Guid id)
        {
            return await new Task<ApiResult<PatientDto>>(null);
        }
    }
}
