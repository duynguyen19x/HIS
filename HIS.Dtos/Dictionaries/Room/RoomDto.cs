using HIS.Application.Core.Services.Dto;
using HIS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Room
{
    public class RoomDto : EntityDto<Guid?>
    {
        public string RoomCode { get; set; }
        public string RoomName { get; set; }
        public string MohCode { get; set; }
        public int? RoomTypeId { get; set; }
        public string RoomTypeCode { get; set; }
        public string RoomTypeName { get; set; }
        public Guid? DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
