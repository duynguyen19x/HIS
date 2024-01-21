using HIS.Core.Services.Dto;

namespace HIS.Core.Services
{
    public interface ICrudAppService<TEntityDto, TPrimaryKey, in TPagedAndSortedResultRequest>
        : IAppService
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TPagedAndSortedResultRequest : IPagedAndSortedResultRequest
    {
        ResultDto<TEntityDto> Get(TPrimaryKey id);

        PagedResultDto<TEntityDto> GetAll(TPagedAndSortedResultRequest input);

        ResultDto<TEntityDto> CreateOrEdit(TEntityDto input);

        ResultDto<TEntityDto> Delete(TPrimaryKey id);

    }
}
