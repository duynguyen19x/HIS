﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Application.Services.Dto
{
    public interface IPagedResultRequest
    {
        int MaxResultCount { get; set; }
        int SkipCount { get; set; }

        string Filter { get; set; }
    }
}
