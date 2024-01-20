using HIS.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Services
{
    public interface IAsyncCrudAppService<TEntityDto, TPrimaryKey, in TPagedAndSortedResultRequest>
        : IAppService
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TPagedAndSortedResultRequest : IPagedAndSortedResultRequest
    {
        Task<ResultDto<TEntityDto>> GetAsync(TPrimaryKey id);

        Task<PagedResultDto<TEntityDto>> GetAllAsync(TPagedAndSortedResultRequest input);

        Task<ResultDto<TEntityDto>> CreateOrEditAsync(TEntityDto input);

        Task<ResultDto<TEntityDto>> DeleteAsync(TPrimaryKey id);
    }
}
