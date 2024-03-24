using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class RelativeTypeConfiguration : IEntityTypeConfiguration<RelativeType>
    {
        public void Configure(EntityTypeBuilder<RelativeType> builder)
        {
            //builder.ToTable("DIC_RelativeType");

            //builder.HasKey(x => x.Id);
            //builder.Property(x => x.RelativeTypeCode).HasMaxLength(20).IsRequired();
            //builder.Property(x => x.RelativeTypeName).HasMaxLength(128).IsRequired();
            //builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F01"), Code = "01", Name = "Bố đẻ", SortOrder = 1 },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F02"), Code = "02", Name = "Mẹ đẻ", SortOrder = 2 },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F03"), Code = "03", Name = "Bố nuôi", SortOrder = 3 },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F04"), Code = "04", Name = "Mẹ nuôi", SortOrder = 4 },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F05"), Code = "05", Name = "Anh ruột", SortOrder = 5 },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F06"), Code = "06", Name = "Chị ruột", SortOrder = 6 },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F07"), Code = "07", Name = "Em ruột", SortOrder = 7 },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F08"), Code = "08", Name = "Ông", SortOrder = 8 },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F09"), Code = "09", Name = "Bà", SortOrder = 9 },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F10"), Code = "10", Name = "Vợ", SortOrder = 10 },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F11"), Code = "11", Name = "Chồng", SortOrder = 11 },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F12"), Code = "12", Name = "Con", SortOrder = 12 },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F13"), Code = "13", Name = "Cháu", SortOrder = 13 },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F14"), Code = "14", Name = "Bác, chú, cậu", SortOrder = 14 },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F15"), Code = "15", Name = "Bác, cô, dì", SortOrder = 15 },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F99"), Code = "99", Name = "Khác", SortOrder = 99 }
                );
        }
    }
}
