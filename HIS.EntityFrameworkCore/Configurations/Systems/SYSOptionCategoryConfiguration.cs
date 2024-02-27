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
    public class SYSOptionCategoryConfiguration : IEntityTypeConfiguration<SYSOptionCategory>
    {
        public void Configure(EntityTypeBuilder<SYSOptionCategory> builder)
        {
            builder.HasData(
                new SYSOptionCategory { Id = 1, Name = "Tùy chọn chung", Description = "", SortOrder = 1 }
                );
        }
    }
}
