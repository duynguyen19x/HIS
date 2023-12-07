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
            builder.ToTable("DIC_RelativeType");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.RelativeTypeCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.RelativeTypeName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F01"), RelativeTypeCode = "01", RelativeTypeName = "Bố đẻ", SortOrder = 1, CreatedDate = SqlDateTimeExtensions.MinValue },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F02"), RelativeTypeCode = "02", RelativeTypeName = "Mẹ đẻ", SortOrder = 2, CreatedDate = SqlDateTimeExtensions.MinValue },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F03"), RelativeTypeCode = "03", RelativeTypeName = "Bố nuôi", SortOrder = 3, CreatedDate = SqlDateTimeExtensions.MinValue },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F04"), RelativeTypeCode = "04", RelativeTypeName = "Mẹ nuôi", SortOrder = 4, CreatedDate = SqlDateTimeExtensions.MinValue },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F05"), RelativeTypeCode = "05", RelativeTypeName = "Anh ruột", SortOrder = 5, CreatedDate = SqlDateTimeExtensions.MinValue },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F06"), RelativeTypeCode = "06", RelativeTypeName = "Chị ruột", SortOrder = 6, CreatedDate = SqlDateTimeExtensions.MinValue },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F07"), RelativeTypeCode = "07", RelativeTypeName = "Em ruột", SortOrder = 7, CreatedDate = SqlDateTimeExtensions.MinValue },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F08"), RelativeTypeCode = "08", RelativeTypeName = "Ông", SortOrder = 8, CreatedDate = SqlDateTimeExtensions.MinValue },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F09"), RelativeTypeCode = "09", RelativeTypeName = "Bà", SortOrder = 9, CreatedDate = SqlDateTimeExtensions.MinValue },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F10"), RelativeTypeCode = "10", RelativeTypeName = "Vợ", SortOrder = 10, CreatedDate = SqlDateTimeExtensions.MinValue },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F11"), RelativeTypeCode = "11", RelativeTypeName = "Chồng", SortOrder = 11, CreatedDate = SqlDateTimeExtensions.MinValue },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F12"), RelativeTypeCode = "12", RelativeTypeName = "Con", SortOrder = 12, CreatedDate = SqlDateTimeExtensions.MinValue },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F13"), RelativeTypeCode = "13", RelativeTypeName = "Cháu", SortOrder = 13, CreatedDate = SqlDateTimeExtensions.MinValue },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F14"), RelativeTypeCode = "14", RelativeTypeName = "Bác, chú, cậu", SortOrder = 14, CreatedDate = SqlDateTimeExtensions.MinValue },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F15"), RelativeTypeCode = "15", RelativeTypeName = "Bác, cô, dì", SortOrder = 15, CreatedDate = SqlDateTimeExtensions.MinValue },
                new RelativeType { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F99"), RelativeTypeCode = "99", RelativeTypeName = "Khác", SortOrder = 99, CreatedDate = SqlDateTimeExtensions.MinValue }
                );
        }
    }
}
