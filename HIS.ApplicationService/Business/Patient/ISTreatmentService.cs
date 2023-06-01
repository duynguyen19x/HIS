﻿using HIS.Dtos.Business.Treatment;
using HIS.Dtos.Commons;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Patient
{
    public interface ISTreatmentService : IBaseService<STreatmentDto, GetAllSTreatmentInput>
    {
    }
}