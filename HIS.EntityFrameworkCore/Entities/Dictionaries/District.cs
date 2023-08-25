﻿using HIS.Core.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Quận, huyện
    /// </summary>
    public class District : FullAuditedEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? ProvinceId { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }

        public virtual Province Province { get; set; }
        public virtual IList<SWard> Wards { get; set; }
    }
}