using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Core.Enums;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class ReceptionObjectTypeConfiguration : IEntityTypeConfiguration<ReceptionObjectType>
    {
        public void Configure(EntityTypeBuilder<ReceptionObjectType> builder)
        {
            builder.ToTable("ReceptionObjectType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ReceptionObjectTypeCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.ReceptionObjectTypeName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);


            builder.HasData(
                new ReceptionObjectType((int)ReceptionTypes.KHAMBENH, "Khám bệnh", 1),
                new ReceptionObjectType((int)ReceptionTypes.CAPCUU, "Cấp cứu", 2)
                );
        }
    }
}
