using HIS.ApplicationService.Business.MedicalRecords.Dto;
using HIS.ApplicationService.Business.Treatments.Dto;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Receptions.Dto
{
    public class ReceptionDto : EntityDto<Guid>
    {
        public DateTime ReceptionDate { get; set; }

        public MedicalRecordDto MedicalRecord { get; set; }
        public TreatmentDto Treatment { get; set; }

        public ReceptionDto() 
        {
            ReceptionDate = DateTime.Now;

            MedicalRecord = new MedicalRecordDto();
            Treatment = new TreatmentDto();
        }
    }
}
