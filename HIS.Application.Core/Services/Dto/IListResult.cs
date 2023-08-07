﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Application.Services.Dto
{
    public interface IListResult<T>
    {
        IReadOnlyList<T> Items { get; set; }
    }
}