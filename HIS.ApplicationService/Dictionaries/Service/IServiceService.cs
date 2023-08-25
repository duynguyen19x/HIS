using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.ExecutionRoom;
using HIS.Dtos.Dictionaries.Service;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.Dtos.Dictionaries.ServiceResultIndex;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Service
{
    public interface IServiceService : IBaseDictionaryService<ServiceDto, GetAllServiceInput>
    {
        Task<ApiResult<bool>> Import(IList<ServiceImportExcelDto> input);
        Task<ApiResult<bool>> ImportServiceResultIndices(IList<ServiceResultIndiceDto> sServiceResultIndexs);
    }
}
