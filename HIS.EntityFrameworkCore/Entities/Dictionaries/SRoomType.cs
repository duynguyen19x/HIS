﻿using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Loại phòng, buồng.
    /// </summary>
    public class SRoomType : Entity<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }

        public virtual IList<SRoom> SRooms { get; set; }
    }
}
