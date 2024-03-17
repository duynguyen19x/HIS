using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Systems
{
    public class SYSLayoutTemplateConfiguration : IEntityTypeConfiguration<SYSLayoutTemplate>
    {
        public void Configure(EntityTypeBuilder<SYSLayoutTemplate> builder)
        {
            
        }
    }
}
