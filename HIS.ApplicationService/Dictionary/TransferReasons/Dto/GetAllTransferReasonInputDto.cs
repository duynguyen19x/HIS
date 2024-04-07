using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.TransferReasons.Dto
{
    public class GetAllTransferReasonInputDto : PagedAndSortedResultRequestDto
    {
        public bool? InactiveFilter { get; set; }
    }
}
