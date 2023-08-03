using HIS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.BaseEntitys
{
    public interface IAuditingEntity<TKey> : IEntity<TKey>
    {
        DateTime? CreatedDate { get; set; }
        Guid? CreatedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
        Guid? ModifiedBy { get; set; }
    }

    public class AuditingEntity<TKey> : Entity<TKey>, IAuditingEntity<TKey>
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
    }
}
