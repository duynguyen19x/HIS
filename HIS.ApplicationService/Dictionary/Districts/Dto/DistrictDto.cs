using HIS.Core.Application.Services.Dto;
using HIS.EntityFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.Districts.Dto
{
    public class DistrictDto : EntityDto<Guid?>
    {
        public virtual string Code { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual bool Inactive { get; set; }

        public virtual Guid ProvinceId { get; set; }

        public virtual string ProvinceCode { get; set; }

        public virtual string ProvinceName { get; set; }
    }
}
