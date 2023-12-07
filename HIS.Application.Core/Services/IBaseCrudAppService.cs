using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.Core.Services
{
    public interface IBaseCrudAppService<TEntityDto, TPrimaryKey, TPagedRequestDto> : IBaseAppService
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TPagedRequestDto : IPagedResultRequestDto
    {
        Task<ResultDto<TEntityDto>> CreateOrEdit(TEntityDto input);
        Task<ResultDto<TEntityDto>> Delete(TPrimaryKey id);
        Task<PagedResultDto<TEntityDto>> GetAll(TPagedRequestDto input);
        Task<ResultDto<TEntityDto>> GetById(TPrimaryKey id);
    }
}
