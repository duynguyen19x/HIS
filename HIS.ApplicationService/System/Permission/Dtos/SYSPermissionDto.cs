using HIS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.Permission.Dtos
{
    public class SYSPermissionDto : Entity<string>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }
        
    }
}
