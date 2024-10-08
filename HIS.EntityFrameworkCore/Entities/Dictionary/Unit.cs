﻿using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Categories;
using System.ComponentModel;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Đơn vị tính
    /// </summary>
    public class Unit : AuditedEntity<Guid>
    {
        [Description("Mã ĐVT")]
        public string Code { get; set; }

        [Description("Tên ĐVT")]
        public string Name { get; set; }

        [Description("Thứ tự sắp xếp")]
        public int? SortOrder { get; set; }

        public int UnitType { get; set; }

        public bool Inactive { get; set; }
    }
}
