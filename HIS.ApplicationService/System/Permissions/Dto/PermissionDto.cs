using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.System.Permissions.Dto
{
    public class PermissionDto : EntityDto<string>
    {
        public virtual string SubSystemId { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }
    }
}
