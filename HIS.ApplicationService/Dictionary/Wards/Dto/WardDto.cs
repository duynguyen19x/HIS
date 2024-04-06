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
        public virtual string Code { get; set; }

        public virtual string Name { get; set; }

        public virtual string SearchCode { get; set; } // viết tắt (T/H/X)

        public virtual string Description { get; set; } // ghi chú

        public virtual bool Inactive { get; set; } // khóa

        public virtual Guid DistrictId { get; set; }

        public virtual string DistrictCode { get; set; }

        public virtual string DistrictName { get; set; }

        public virtual Guid ProvinceId { get; set; }

        public virtual string ProvinceCode { get; set; }

        public virtual string ProvinceName { get; set; }
    }
}
