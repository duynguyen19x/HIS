﻿using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.Entities.Categories.Services
{
    /// <summary>
    /// Loại phẫu thuật thủ thuật
    /// </summary>
    public class SSurgicalProcedureType : Entity<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int? SortOrder { get; set; }

        public IList<SService> SServices { get; set; }
    }
}
