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
        public Guid PatientID { get; set; }
        public Guid MedicalRecordID { get; set; }
        public DateTime TreatmentDate { get; set; }
        public string TreatmentCode { get; set; }

        public Guid BranchID { get; set; }
        public Guid DepartmentID { get; set; }
        public Guid RoomID { get; set; }


        public Guid? TreatmentID_IN { get; set; }
        public DateTime TreatmentDate_IN { get; set; }


        public DateTime TreatmentDate_OUT { get; set; }

    }
}
