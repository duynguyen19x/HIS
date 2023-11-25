﻿using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Tôn giáo.
    /// </summary>
    public class Religion : AuditedEntity<Guid>
    {
        public string ReligionCode { get; set; }
        public string ReligionName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public Religion() { }
    }
}
