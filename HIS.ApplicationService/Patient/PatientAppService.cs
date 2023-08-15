using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Dtos.Patient;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<ApiResult<PatientDto>> Create(PatientDto input)
        {
            return await Task.FromResult(new ApiResult<PatientDto> { });
        }
    }
}
