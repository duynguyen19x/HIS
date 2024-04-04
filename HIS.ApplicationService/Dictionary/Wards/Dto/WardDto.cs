using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Ward
{
    public class WardDto : EntityDto<Guid?>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string SearchText { get; set; }

        public Guid? ProvinceId { get; set; }

        public string ProvinceName { get; set; }

        public Guid? DistrictId { get; set; }

        public string DistrictName { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }
    }
}
