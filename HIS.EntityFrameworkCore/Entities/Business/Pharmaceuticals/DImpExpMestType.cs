﻿using HIS.Core.Entities;

namespace HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals
{
    public class DImpExpMestType : Entity<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Inactive { get; set; }
    }
}