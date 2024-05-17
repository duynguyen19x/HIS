using HIS.ApplicationService.Business.Patients.Dto;
using HIS.Core.Application.Services.Dto;
using HIS.EntityFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.MedicalRecords.Dto
{
    public class MedicalRecordDto : EntityDto<Guid?>
    {
        public string MedicalRecordCode { get; set; }
        public DateTime MedicalRecordDate { get; set; }
        

        public PatientDto Patient { get; set; }

        public MedicalRecordDto()
        {
            MedicalRecordDate = DateTime.Now;

            Patient = new PatientDto();
        }
    }
}
