﻿using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Chi nhánh
    /// </summary>
    public class Branch : Entity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}