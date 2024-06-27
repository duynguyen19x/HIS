using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities
{
    public class Machine : AuditedEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int MachineType { get; set; } //Loại máy
        public int MachineOrderType { get; set; } //Lọi máy đặt
        public Guid? RoomId { get; set; } //Phòng
        public Guid? DepartmentId { get; set; } //Khoa
        public DateTime CreationDate { get; set; } //Ngày tạo
        public string Creator { get; set; } //Người tạo
        public string Description { get; set; } //Mô tả
        public string UsageStandard { get; set; } //Định mức sử dụng
        public bool Inactive { get; set; }


        public Room RoomFk { get; set; }

        public Department DepartmentFk { get; set; }
    }
}
