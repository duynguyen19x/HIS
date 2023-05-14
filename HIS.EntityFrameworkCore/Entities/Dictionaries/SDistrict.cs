﻿using HIS.EntityFrameworkCore.BaseEntitys;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Quận, huyện
    /// </summary>
    public class SDistrict : FullAuditingEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid ProvinceId { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }

        public virtual SProvince Province { get; set; }
        public virtual IList<SWard> Wards { get; set; }
    }
}