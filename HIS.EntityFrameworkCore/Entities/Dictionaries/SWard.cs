using HIS.EntityFrameworkCore.BaseEntitys;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Xã, phường.
    /// </summary>
    public class SWard : FullAuditingEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? DistrictId { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }

        public virtual SDistrict District { get; set; }
    }
}
