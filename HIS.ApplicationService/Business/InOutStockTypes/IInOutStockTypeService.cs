using HIS.ApplicationService.Business.InOutStockTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Business.InOutStockTypes
{
    public interface IInOutStockTypeService : IAppService
    {
        Task<PagedResultDto<InOutStockTypeDto>> GetAll(GetAllInOutStockTypeInput input);
    }
}
