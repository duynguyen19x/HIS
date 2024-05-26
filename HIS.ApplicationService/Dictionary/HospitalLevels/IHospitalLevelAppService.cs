using HIS.ApplicationService.Dictionary.Branchs.Dto;
using HIS.ApplicationService.Dictionary.HospitalLevels.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Branchs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.HospitalLevels
{
    public interface IHospitalLevelAppService : IAppService
    {
        Task<PagedResultDto<HospitalLevelDto>> GetAll(GetAllHospitalLevelInputDto input);

        Task<ResultDto<HospitalLevelDto>> Get(Guid id);

        Task<ResultDto<HospitalLevelDto>> CreateOrEdit(HospitalLevelDto input);

        Task<ResultDto<HospitalLevelDto>> Delete(Guid id);
    }
}
