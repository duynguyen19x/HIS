using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.InvoiceGroups.Dto
{
    public class GetAllInvoiceGroupInputDto : PagedAndSortedResultRequestDto
    {
        public string CodeFilter { get; set; }

        public string NameFilter { get; set; }

        public bool? InactiveFilter { get; set; }

        public Guid? UserFilter { get; set; }
    }
}
