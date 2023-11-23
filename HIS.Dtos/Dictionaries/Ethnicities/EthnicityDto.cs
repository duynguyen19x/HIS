using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Ethnicities
{
    public class EthnicityDto : EntityDto<Guid>
    {
        public string EthnicityCode { get; set; }
        public string EthnicityName { get; set; }
        public string MohCode { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
