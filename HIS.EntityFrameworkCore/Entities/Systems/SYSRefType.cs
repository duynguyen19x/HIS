using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities;
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

        public int? RefTypeCategoryID { get; set; }

        public int? ParentID { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        [Ignore]
        public SYSRefTypeCategory RefTypeCategoryFk { get; set; }
    }
}
