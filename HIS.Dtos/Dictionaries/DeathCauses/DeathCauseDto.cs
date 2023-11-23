using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.DeathCauses
{
    public class DeathCauseDto : EntityDto<Guid>
    {
        public string DeathCauseCode { get; set; }
        public string DeathCauseName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
