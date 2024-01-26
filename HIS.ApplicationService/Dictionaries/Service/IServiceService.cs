using HIS.Application.Core.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Service;
using HIS.Dtos.Dictionaries.ServiceResultIndex;

namespace HIS.ApplicationService.Dictionaries.Service
{
    public interface IServiceService : IBaseCrudAppService<ServiceDto, Guid?, GetAllServiceInput>
    {
        Task<ResultDto<bool>> Import(IList<ServiceImportExcelDto> input);
        Task<ResultDto<bool>> ImportServiceResultIndices(IList<ServiceResultIndiceDto> sServiceResultIndexs);
    }
}
