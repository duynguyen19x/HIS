using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities.Systems;

namespace HIS.EntityFrameworkCore.Configurations.Systems
{
    public class DbOptionConfigurations : IEntityTypeConfiguration<DbOption>
    {
        public void Configure(EntityTypeBuilder<DbOption> builder)
        {
            builder.ToTable("DbOptions");
            builder.HasKey(x => x.Id);
        }
    }
}
