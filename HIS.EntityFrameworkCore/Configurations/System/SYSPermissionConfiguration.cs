using HIS.EntityFrameworkCore.Constants;
using HIS.EntityFrameworkCore.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Systems
{
    public class SYSPermissionConfiguration : IEntityTypeConfiguration<SYSPermission>
    {
        public void Configure(EntityTypeBuilder<SYSPermission> builder)
        {
            builder.HasData(
                new SYSPermission() { Id = PermissionConst.HIS_SYSTEM, Name= "Hệ thống", SortOrder = 1 },

                new SYSPermission() { Id = PermissionConst.HIS_SYSTEM__OPTION, Name = "Tùy chọn", ParentId = PermissionConst.HIS_SYSTEM, SortOrder = 99 }
                );
        }
    }
}
