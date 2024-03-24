using HIS.ApplicationService.Dictionary.RoomTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.RoomTypes
{
    public interface IRoomTypeAppService : IAppService
    {
        Task<ResultDto<RoomTypeDto>> CreateOrUpdateAsync(RoomTypeDto input);

        Task<ResultDto<RoomTypeDto>> DeleteAsync(int id);

        Task<PagedResultDto<RoomTypeDto>> GetAllAsync(GetAllRoomTypeInputDto input);

        Task<ResultDto<RoomTypeDto>> GetAsync(int id);
    }
}
