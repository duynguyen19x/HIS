using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin tử vong.
    /// </summary>
    public class Death : FullAuditedEntity<Guid>
    {
        public virtual Guid TreatmentId { get; set; }
        public virtual Guid? TreatmentRecordId { get; set; }
        public virtual Guid BranchId { get; set; }
        public virtual Guid? DeathCertBookId { get; set; } // quyển (giấy báo tử)
        public virtual string DeathNo { get; set; } // số (giấy báo tử)
        public virtual DateTime DeathTime { get; set; } // thời điểm tử vong
        public virtual int DeathCauseId { get; set; } // nguyên nhân tử vong
        public virtual int DeathWithinId { get; set; } // thời gian tử vong
        public virtual string IcdCode { get; set; } // nguyên nhân chính
        public virtual string IcdName { get; set; } // tên nguyên nhân chính
        public virtual bool IsHasAutospy { get; set; } //  có khám nghiệm tử thi
        public virtual string AutospyIcdCode { get; set; } // nguyên nhân giải phẫu
        public virtual string AutospyIcdName { get; set; } // tên nguyên nhân giải phẫu
    }
}
