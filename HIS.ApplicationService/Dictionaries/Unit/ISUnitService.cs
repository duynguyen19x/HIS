﻿using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.ServiceUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Unit
{
    public  interface ISUnitService : IBaseDictionaryService<SUnitDto, GetAllSUnitInput>
    {
    }
}