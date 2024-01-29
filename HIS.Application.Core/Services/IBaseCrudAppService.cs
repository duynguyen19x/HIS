using HIS.Core.Services.Dto;

namespace HIS.Application.Core.Services
{
    public interface IBaseCrudAppService<TEntityDto, TPrimaryKey, TPagedRequestDto> : IBaseAppService
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TPagedRequestDto : IPagedResultRequest
    {
        Task<ResultDto<TEntityDto>> CreateOrEdit(TEntityDto input);
        Task<ResultDto<TEntityDto>> Delete(TPrimaryKey id);
        Task<PagedResultDto<TEntityDto>> GetAll(TPagedRequestDto input);
        Task<ResultDto<TEntityDto>> GetById(TPrimaryKey id);
    }
}
