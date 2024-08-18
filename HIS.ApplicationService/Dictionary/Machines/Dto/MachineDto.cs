using HIS.Core.Application.Services.Dto;

namespace HIS.Dtos.Dictionaries.Machines
{
    public class MachineDto : EntityDto<Guid?>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int MachineType { get; set; } //Loại máy
        public int MachineOrderType { get; set; } //Lọi máy đặt
        public Guid? RoomId { get; set; } //Phòng
        public Guid? DepartmentId { get; set; } //Khoa
        public string Description { get; set; } //Mô tả
        public string UsageStandard { get; set; } //Định mức sử dụng
        public bool Inactive { get; set; }
    }
}
