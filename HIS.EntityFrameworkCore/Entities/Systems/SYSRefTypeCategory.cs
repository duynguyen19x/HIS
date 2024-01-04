using HIS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    public class SYSRefTypeCategory : Entity<int>
    {
        public string RefTypeCategoryName { get; set; }
        public string Description { get; set; }
        public int SortOrder {  get; set; } 
    }
}
