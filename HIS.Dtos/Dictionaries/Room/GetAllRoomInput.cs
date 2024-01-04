using HIS.Application.Core.Services.Dto;

namespace HIS.Dtos.Dictionaries.Room
{
    public class GetAllRoomInput : PagedResultRequestDto
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public int? RoomTypeIdFilter { get; set; }
        public Guid? DepartmentIdFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
