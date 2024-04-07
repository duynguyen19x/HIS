using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.TreatmentEndTypes.Dto
{
    public class GetAllTreatmentEndTypeInputDto : PagedAndSortedResultRequestDto
    {
        public virtual string CodeFilter { get; set; }

        public virtual string NameFilter { get; set; }

        public virtual bool? IsForOutPatientFilter { get; set; }

        public virtual bool? IsForInPatientFilter { get; set; }

        public virtual bool? InactiveFilter { get; set; }

    }
}
