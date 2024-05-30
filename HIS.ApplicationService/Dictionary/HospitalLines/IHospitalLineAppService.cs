using HIS.ApplicationService.Dictionary.HospitalLevels.Dto;
using HIS.ApplicationService.Dictionary.HospitalLines.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.HospitalLines
{
    public interface IHospitalLineAppService : IAppService
    {
        Task<PagedResultDto<HospitalLineDto>> GetAll(GetAllHospitalLineInputDto input);

        Task<ResultDto<HospitalLineDto>> Get(Guid id);

        Task<ResultDto<HospitalLineDto>> CreateOrEdit(HospitalLineDto input);

        Task<ResultDto<HospitalLineDto>> Delete(Guid id);
    }
}
