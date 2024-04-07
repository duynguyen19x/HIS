using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.RoomTypes.Dto
{
    public class GetAllRoomTypeInputDto : PagedAndSortedResultRequestDto
    {
        public string CodeFilter { get; set; }

        public string NameFilter { get; set; }

        public bool? InactiveFilter { get; set; }
    }
}
