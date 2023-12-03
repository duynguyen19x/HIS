﻿using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Loại phòng, buồng.
    /// </summary>
    public class RoomType : AuditedEntity<int>
    {
        public string RoomTypeCode { get; set; }
        public string RoomTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
