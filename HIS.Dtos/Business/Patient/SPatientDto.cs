using HIS.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Patient
{
    public class SPatientDto : EntityDto<Guid?>
    {
        public string PatientCode { get; set; }
        public string PatientName { get; set; }
        public string FirstName { get; set; }
    }
}
