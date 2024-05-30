using HIS.ApplicationService.Dictionary.HospitalLines.Dto;
using HIS.ApplicationService.Dictionary.HospitalSpecialities.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.HospitalSpecialities
{
    public interface IHospitalSpecialityAppService : IAppService
    {
        Task<PagedResultDto<HospitalSpecialityDto>> GetAll(GetAllHospitalSpecialityInputDto input);

        Task<ResultDto<HospitalSpecialityDto>> Get(Guid id);

        Task<ResultDto<HospitalSpecialityDto>> CreateOrEdit(HospitalSpecialityDto input);

        Task<ResultDto<HospitalSpecialityDto>> Delete(Guid id);
    }
}
