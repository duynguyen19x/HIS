using HIS.ApplicationService.Business.Receptions.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Business.Receptions
{
    /// <summary>
    /// Phòng tiếp đón.
    /// </summary>
    public interface IReceptionAppService : IAppService
    {
        Task<PagedResultDto<ReceptionDto>> GetAll(GetAllReceptionInputDto input);

        Task<ResultDto<ReceptionDto>> GetById(Guid id);

        Task<ResultDto<ReceptionDto>> CreateOrEdit(ReceptionDto input);

        Task<ResultDto<ReceptionDto>> Delete(Guid id);
    }
}
