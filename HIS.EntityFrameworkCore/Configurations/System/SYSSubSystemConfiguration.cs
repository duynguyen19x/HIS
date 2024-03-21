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
    public class SYSSubSystemConfiguration : IEntityTypeConfiguration<SubSystem>
    {
        public void Configure(EntityTypeBuilder<SubSystem> builder)
        {
            var data = new List<SubSystem>
            {
                
            };

            builder.HasData(data);
        }
    }
}
