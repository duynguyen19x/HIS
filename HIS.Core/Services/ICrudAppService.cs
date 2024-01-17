using HIS.Core.Services.Dto;

namespace HIS.Core.Services
{
    public interface ICrudAppService<TEntityDto, TPrimaryKey, in TPagedResultRequest>
        : IAppService
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TPagedResultRequest : IPagedResultRequest
    {
        Task<ResultDto<TEntityDto>> Get(TPrimaryKey id);

        Task<PagedResultDto<TEntityDto>> GetAll(TPagedResultRequest input);

        Task<ResultDto<TEntityDto>> CreateOrEdit(TEntityDto input);

        Task<ResultDto<TEntityDto>> Delete(TPrimaryKey id);

    }
}
