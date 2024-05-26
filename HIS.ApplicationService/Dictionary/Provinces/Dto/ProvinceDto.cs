using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Province
{
    public class ProvinceDto : EntityDto<Guid?>
    {
        public string ProvinceCode { get; set; }

        public string ProvinceName { get; set; }

        public string Description { get; set; }

        public bool Inactive { get; set; }
    }
}
