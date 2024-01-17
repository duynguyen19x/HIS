using HIS.Application.Core.Services;
using HIS.Core.Services.Dto;
using HIS.Dtos.Business.InOutStockTypes;

namespace HIS.ApplicationService.Business.InOutStockType
{
    public interface IInOutStockTypeService: IBaseAppService
    {
        Task<PagedResultDto<InOutStockTypeDto>> GetAll(GetAllInOutStockTypeInput input);
    }
}
