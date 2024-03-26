using HIS.ApplicationService.Dictionary.Genders.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Genders
{
    public interface IGenderAppService : IAppService
    {
        Task<ResultDto<GenderDto>> CreateOrEdit(GenderDto input);
        Task<ResultDto<GenderDto>> Delete(Guid id);
        Task<PagedResultDto<GenderDto>> GetAll(GetAllGenderInputDto input);
        Task<ResultDto<GenderDto>> GetById(Guid id);
    }
}
