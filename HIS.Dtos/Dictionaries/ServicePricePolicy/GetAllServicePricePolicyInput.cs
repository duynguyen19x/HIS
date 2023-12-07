using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ServicePricePolicy
{
    public class GetAllServicePricePolicyInput : PagedResultRequestDto
    {
        public Guid? ServiceIdFilter { get; set; }
        public Guid? PatientTypeIdFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
