using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Ward
{
    public class WardDto : EntityDto<Guid?>
    {
        public string WardCode { get; set; }

        public string WardName { get; set; }

        public string SearchCode { get; set; } // viết tắt (T/H/X)

        public string Description { get; set; } // ghi chú

        public bool Inactive { get; set; } // khóa

        public Guid DistrictID { get; set; }

        public string DistrictName { get; set; }

        public string DistrictCode { get; set; }

        public Guid ProvinceID { get; set; }

        public string ProvinceName { get; set; }

        public string ProvinceCode { get; set; }

        
    }
}
