using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Rooms.Dto
{
    public interface IRoomAppService : IAppService
    {
        Task<ResultDto<RoomDto>> CreateOrUpdateAsync(RoomDto input);

        Task<ResultDto<RoomDto>> DeleteAsync(Guid id);

        Task<PagedResultDto<RoomDto>> GetAllAsync(GetAllRoomInputDto input);

        Task<ResultDto<RoomDto>> GetAsync(Guid id);

        Task<PagedResultDto<RoomDto>> GetByStocks();
    }
}
