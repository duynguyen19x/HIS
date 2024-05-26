using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Treatments.Dto
{
    public class TreatmentDto : EntityDto<Guid>
    {
        public Guid PatientId { get; set; }
        public Guid MedicalRecordId { get; set; }
        public DateTime TreatmentDate { get; set; }
        public string TreatmentCode { get; set; }

        public Guid BranchId { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid RoomId { get; set; }


        public Guid? TreatmentId_IN { get; set; }
        public DateTime TreatmentDate_IN { get; set; }


        public DateTime TreatmentDate_OUT { get; set; }

    }
}
