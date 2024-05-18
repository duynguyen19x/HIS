using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Patients.Dto
{
    public class PatientOrderDto : EntityDto<Guid>
    {
        public DateTime PatientOrderDate { get; set; }
        public int SortOrder { get; set; }
    }
}
