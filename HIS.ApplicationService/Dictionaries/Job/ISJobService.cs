﻿using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.Branch;
using HIS.Dtos.Dictionaries.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Job
{
    public interface ISJobService : IBaseDictionaryService<SJobDto, GetAllSJobInput>
    {
    }
}
