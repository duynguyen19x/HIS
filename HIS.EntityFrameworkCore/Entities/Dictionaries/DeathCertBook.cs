﻿using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Giấy báo tử.
    /// </summary>
    public class DeathCertBook : AuditedEntity<Guid>
    {
        public Guid BranchID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Total {  get; set; }
        public int StartNumOrder { get; set; }
        public int SortOrder { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }

        public DeathCertBook() { }
    }
}
