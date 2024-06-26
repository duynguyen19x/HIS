﻿using HIS.Core.Application.Services.Dto;
using HIS.EntityFrameworkCore.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.HospitalSpecialities.Dto
{
    public class HospitalSpecialityDto : EntityDto<Guid?>
    {
        public string HospitalSpecialityCode { get; set; }

        public string HospitalSpecialityName { get; set; }

        public string Description { get; set; }

        public bool Inactive { get; set; }

        public int SortOrder { get; set; }
    }
}
