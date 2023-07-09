using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.BaseEntitys
{
    public interface IFullAuditingEntity<TKey> : IAuditingEntity<TKey>
    {
        public DateTime? DeleteDate { get; set; }
        public Guid? DeleteBy { get; set; }
    }

    public class FullAuditingEntity<TKey> : Entity<TKey>, IFullAuditingEntity<TKey>
    {
        private DateTime? _createdDate;
        public DateTime? CreatedDate
        {
            get => _createdDate ?? DateTime.Now;
            set => _createdDate = value;
        }

        private Guid? _createdBy;
        public Guid? CreatedBy
        {
            get => _createdBy;
            set => _createdBy = value;
        }

        public DateTime? ModifiedDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? DeleteDate { get; set; }

        public Guid? DeleteBy { get; set; }

        public bool IsDelete { get; set; }
    }
}
