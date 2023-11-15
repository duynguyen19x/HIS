using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class ServiceReq : FullAuditedEntity<Guid>
    {
        public virtual string NgayYLenh { get; set; }
        public virtual string NguoiYLenh { get; set; }
        public virtual string ChiNhanh { get; set; }
        public virtual string KhoaChiDinh { get; set; }
        public virtual string PhongChiDinh { get; set; }
        public virtual string ChanDoan { get; set; }
        public virtual string BenhKemTheo { get; set; }
        public virtual string GhiChu { get; set; }
        public virtual bool LaCapCuu { get; set; }
        public virtual bool LaUuTien { get; set; }

        public virtual Guid PatientRecordId { get; set; }
        public virtual Guid MedicalRecordId { get; set; }
        public virtual int TreatmentId { get; set; }
    }
}
