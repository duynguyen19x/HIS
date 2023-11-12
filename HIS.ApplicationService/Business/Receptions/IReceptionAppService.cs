using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.PatientRecords;
using HIS.Dtos.Business.Receptions;

namespace HIS.ApplicationService.Business.Receptions
{
    public interface IReceptionAppService : IBaseCrudAppService<ReceptionDto, Guid, PagedReceptionInputDto>
    {
    }
}
