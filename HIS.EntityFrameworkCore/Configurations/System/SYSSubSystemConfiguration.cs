using HIS.EntityFrameworkCore.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.System
{
    public class SYSSubSystemConfiguration : IEntityTypeConfiguration<SYSSubSystem>
    {
        public void Configure(EntityTypeBuilder<SYSSubSystem> builder)
        {
            var data = new List<SYSSubSystem>
            {
                
            };

            builder.HasData(data);
        }
    }
}
