﻿using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin phiếu điều trị.
    /// </summary>
    public class Treatment : FullAuditedEntity<Guid>
    {
        
    }
}
