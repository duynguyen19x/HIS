using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class SYSRefType : Entity<int>
    {
        public string RefTypeName { get; set; }
        public int? RefTypeCategoryId { get; set; }
        public int? ParentId { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }

        [Ignore]
        public SYSRefTypeCategory SYSRefTypeCategory { get; set; }
    }
}
