using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.PatientRecords;
using HIS.Dtos.Business.Receptions;

namespace HIS.ApplicationService.Business.Receptions
{
    public interface IReceptionAppService : IBaseAppService
    {
        Task<ResultDto<ReceptionDto>> CreateOrEdit(ReceptionDto input);
        Task<ResultDto<ReceptionDto>> Delete(Guid id);
        Task<PagedResultDto<ReceptionDto>> GetAll(PagedReceptionInputDto input);
        Task<ResultDto<ReceptionDto>> GetById(Guid id);
    }
}
