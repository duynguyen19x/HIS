using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.RoomType;

namespace HIS.ApplicationService.Dictionaries.RoomType
{
    public interface IRoomTypeService : IBaseCrudAppService<RoomTypeDto, int, GetAllRoomTypeInput>
    {
    }
}
