using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Treatments
{
    /// <summary>
    /// Thông tin điều trị.
    /// </summary>
    public class TreatmentDto : EntityDto<Guid>
    {
        public Guid MedicalRecordID { get; set; }
    }
}
