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
        public string DistrictCode { get; set; }

        public string DistrictName { get; set; }

        public string Description { get; set; }

        public bool Inactive { get; set; }

        public Guid ProvinceID { get; set; }

        public string ProvinceName { get; set; }

        public string ProvinceCode { get; set; }

    }
}
