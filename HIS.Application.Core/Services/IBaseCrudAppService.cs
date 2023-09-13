using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.Core.Services
{
    public interface IBaseCrudAppService<TEntityDto, TKey, TPagedRequestDto> : IBaseAppService
        where TEntityDto : IEntityDto<TKey>
        where TPagedRequestDto : IPagedResultRequest
    {
        Task<ResultDto<TEntityDto>> CreateOrEdit(TEntityDto input);
        Task<ResultDto<TEntityDto>> Delete(TKey id);
        Task<PagedResultDto<TEntityDto>> GetAll(TPagedRequestDto input);
        Task<ResultDto<TEntityDto>> GetById(TKey id);
    }
}
