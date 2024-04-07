using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin chuyển viện
    /// </summary>
    [Table("HISMedicalRecordTransfer")]
    public class MedicalRecordTransfer : AuditedEntity<Guid>
    {
        public virtual Guid PatientId { get; set; }

        public virtual Guid PatientRecordId { get; set; }

        public virtual Guid MedicalRecordId { get; set; }

        public virtual Guid? TreatmentId { get; set; }

        public DateTime? TransferTime { get; set; }

        public int TransferTypeId { get; set; } // chuyển tuyến: khám bệnh, điều trị

        [MaxLength(255)]
        public string TransferMediOrgCode { get; set; }

        [MaxLength(255)]
        public string TransferMediOrgName { get; set; }

        [MaxLength(255)]
        public string Transporter { get; set; } // người vận chuyển

        [MaxLength(255)]
        public string TransportVehicle { get; set; } // phương tiện vận chuyển

        public Guid? TransferFormId { get; set; } // hình thức chuyển viện

        public Guid? TransferReasonId { get; set; } //lý do chuyển viện

        public bool TransferRouteRight { get; set; } // chuyển đúng tuyến CMKT

        public bool TransferRouteOver { get; set; } // chuyển vượt tuyến CMKT
    }
}
