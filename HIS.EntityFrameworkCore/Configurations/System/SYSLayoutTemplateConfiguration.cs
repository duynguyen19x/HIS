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
    public class SYSLayoutTemplateConfiguration : IEntityTypeConfiguration<LayoutTemplate>
    {
        public void Configure(EntityTypeBuilder<LayoutTemplate> builder)
        {
            
        }
    }
}
