﻿using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.Icd;
using HIS.Dtos.Dictionaries.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Icd
{
    public interface ISIcdService : IBaseDictionaryService<SIcdDto, GetAllSIcdInput>
    {
    }
}
