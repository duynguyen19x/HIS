using HIS.Application.Core.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Room;

namespace HIS.ApplicationService.Dictionaries.Room
{
    public interface IRoomAppService : IBaseCrudAppService<RoomDto, Guid?, GetAllRoomInput>
    {
        Task<PagedResultDto<RoomDto>> GetByStocks();
    }
}
