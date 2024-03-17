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
    public class SYSRoleConfiguration : IEntityTypeConfiguration<SYSUser>
    {
        public void Configure(EntityTypeBuilder<SYSUser> builder)
        {
            
        }
    }
}
