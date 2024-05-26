using HIS.Core.Application.Services.Dto;
using HIS.EntityFrameworkCore.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.HospitalLines.Dto
{
    public class HospitalLineDto : EntityDto<Guid?>
    {
        public string HospitalLevelCode { get; set; }

        public string HospitalLevelName { get; set; }

        public string Description { get; set; }

        public bool Inactive { get; set; }

        public int SortOrder { get; set; }
    }
}
