using HIS.ApplicationService.Dictionary.Hospitals.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Hospitals
{
    public interface IHospitalService : IAppService
    {
        Task<ResultDto<HospitalDto>> CreateOrEdit(HospitalDto input);
        Task<ResultDto<HospitalDto>> Delete(Guid id);
        Task<PagedResultDto<HospitalDto>> GetAll(GetAllHospitalInputDto input);
        Task<ResultDto<HospitalDto>> GetById(Guid id);
    }
}
