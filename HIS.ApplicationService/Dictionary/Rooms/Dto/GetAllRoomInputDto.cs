using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Rooms.Dto
{
    public class GetAllRoomInputDto : PagedAndSortedResultRequestDto
    {
        public string CodeFilter { get; set; }

        public string NameFilter { get; set; }

        public int? RoomTypeFilter { get; set; }

        public Guid? DepartmentFilter { get; set; }

        public bool? InactiveFilter { get; set; }
    }
}
