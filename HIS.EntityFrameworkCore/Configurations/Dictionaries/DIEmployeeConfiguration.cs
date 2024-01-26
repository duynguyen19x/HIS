using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class DIEmployeeConfiguration : IEntityTypeConfiguration<DIEmployee>
    {
        public void Configure(EntityTypeBuilder<DIEmployee> builder)
        {
            builder.ToTable("DIEmployee");
            builder.HasKey(x => x.Id);
        }
    }
}
