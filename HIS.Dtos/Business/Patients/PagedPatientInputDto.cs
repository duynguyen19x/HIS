﻿using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Patients
{
    public class PagedPatientInputDto : PagedResultRequestDto
    {
        public virtual string CodeFilter { get; set; }
    }
}