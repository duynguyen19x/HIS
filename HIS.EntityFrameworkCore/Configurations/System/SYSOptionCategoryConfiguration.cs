using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Systems
{
    public class SYSOptionCategoryConfiguration : IEntityTypeConfiguration<DBOptionCategory>
    {
        public void Configure(EntityTypeBuilder<DBOptionCategory> builder)
        {
            builder.HasData(
                new DBOptionCategory { Id = 1, Name = "Tùy chọn chung", Description = "", SortOrder = 1 }
                );
        }
    }
}
