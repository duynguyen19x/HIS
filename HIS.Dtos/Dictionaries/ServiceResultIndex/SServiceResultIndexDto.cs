using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ServiceResultIndex
{
    public class SServiceResultIndiceDto : EntityDto<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal? MaleFrom { get; set; }
        public decimal? MaleTo { get; set; }
        public decimal? FemaleFrom { get; set; }
        public decimal? FemaleTo { get; set; }
        public Guid? ServiceId { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }
        public decimal Result { get; set; }

        public string ServiceCode { get; set; }
    }
}
