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
    public class SYSOptionCategoryConfiguration : IEntityTypeConfiguration<OptionCategory>
    {
        public void Configure(EntityTypeBuilder<OptionCategory> builder)
        {
            builder.HasData(
                new OptionCategory { Id = 1, Name = "Tùy chọn chung", Description = "", SortOrder = 1 }
                );
        }
    }
}
