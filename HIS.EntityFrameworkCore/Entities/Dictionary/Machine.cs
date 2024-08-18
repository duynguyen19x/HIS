using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Constants;
using System.ComponentModel.DataAnnotations;

namespace HIS.EntityFrameworkCore.Entities
{
    public class Machine : AuditedEntity<Guid>
    {
        [MaxLength(EntityConst.Length50)]
        public string Code { get; set; }
        [MaxLength(EntityConst.Length512)]
        public string Name { get; set; }
        public int MachineType { get; set; } // Loại máy
        public int MachineOrderType { get; set; } // Lọi máy đặt
        public Guid? RoomId { get; set; } // Phòng
        public Guid? DepartmentId { get; set; } // Khoa
        [MaxLength(EntityConst.Length512)]
        public string Description { get; set; } // Mô tả
        [MaxLength(EntityConst.Length512)]
        public string UsageStandard { get; set; } // Định mức sử dụng
        public bool Inactive { get; set; }


        public Room RoomFk { get; set; }

        public Department DepartmentFk { get; set; }
    }
}
