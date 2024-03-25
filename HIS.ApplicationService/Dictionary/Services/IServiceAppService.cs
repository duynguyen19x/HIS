using HIS.ApplicationService.Dictionary.Services.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.ServiceResultIndex;

namespace HIS.ApplicationService.Dictionary.Services
{
    public interface IServiceAppService : IAppService
    {
        Task<ResultDto<ServiceDto>> CreateOrEdit(ServiceDto input);
        Task<ResultDto<ServiceDto>> Delete(Guid id);
        Task<PagedResultDto<ServiceDto>> GetAll(GetAllServiceInput input);
        Task<ResultDto<ServiceDto>> GetById(Guid id);

        Task<ResultDto<bool>> Import(IList<ServiceImportExcelDto> input);
        Task<ResultDto<bool>> ImportServiceResultIndices(IList<ServiceResultIndiceDto> sServiceResultIndexs);
    }
}
