﻿using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Patient
{
    public class GetAllSPatientInput : PagedResultRequestDto
    {
        public string PatientCodeFilter { get; set; }
    }
}
