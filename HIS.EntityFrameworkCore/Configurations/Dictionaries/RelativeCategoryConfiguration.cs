using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class RelativeCategoryConfiguration : IEntityTypeConfiguration<RelativeCategory>
    {
        public void Configure(EntityTypeBuilder<RelativeCategory> builder)
        {
            builder.ToTable("RelativeCategory");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.RelativeCategoryCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.RelativeCategoryName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new RelativeCategory { Id = new Guid("E48761EB-808A-476D-8E3B-B4D9A8847816"), RelativeCategoryCode = "BO_DE", RelativeCategoryName = "Bố đẻ", SortOrder = 1 },
                new RelativeCategory { Id = new Guid("40BE44A5-1E37-4DD7-A2A0-1D72CF1DFBC8"), RelativeCategoryCode = "ME_DE", RelativeCategoryName = "Mẹ đẻ", SortOrder = 2 },
                new RelativeCategory { Id = new Guid("FEDEBD7D-79A5-4345-99C8-C1AB7FF4851B"), RelativeCategoryCode = "BO_NUOI", RelativeCategoryName = "Bố nuôi", SortOrder = 3 },
                new RelativeCategory { Id = new Guid("4EC94138-BA06-43EC-BAE0-B9A04810268A"), RelativeCategoryCode = "ME_NUOI", RelativeCategoryName = "Mẹ nuôi", SortOrder = 4 },
                new RelativeCategory { Id = new Guid("2316B5E0-2ECD-4EB7-9002-F5F6187AD3AD"), RelativeCategoryCode = "ANH", RelativeCategoryName = "Anh", SortOrder = 5 },
                new RelativeCategory { Id = new Guid("D52FADE4-72DF-4521-9ED2-14CD59A1F03A"), RelativeCategoryCode = "CHI", RelativeCategoryName = "Chị", SortOrder = 6 },
                new RelativeCategory { Id = new Guid("A5C7B854-C2E2-4E39-956D-A0B90B19BDC5"), RelativeCategoryCode = "EM", RelativeCategoryName = "Em", SortOrder = 7 },
                new RelativeCategory { Id = new Guid("23F18050-2A5E-45F7-A8AE-B543E2800181"), RelativeCategoryCode = "ONG", RelativeCategoryName = "Ông", SortOrder = 8 },
                new RelativeCategory { Id = new Guid("C89B25AC-2806-40D5-98DF-17D3F4586F3B"), RelativeCategoryCode = "BA", RelativeCategoryName = "Bà", SortOrder = 9 },
                new RelativeCategory { Id = new Guid("3C10868D-7998-4C90-BF54-B2F0AED7CF3E"), RelativeCategoryCode = "CON", RelativeCategoryName = "Con", SortOrder = 10 },
                new RelativeCategory { Id = new Guid("B1411322-4391-4860-B704-5B96D7738EEE"), RelativeCategoryCode = "VO", RelativeCategoryName = "Vợ", SortOrder = 11 },
                new RelativeCategory { Id = new Guid("3961E0CD-E61B-4A6F-B3E0-70CCB8864AD6"), RelativeCategoryCode = "CHONG", RelativeCategoryName = "Chồng", SortOrder = 12 },
                new RelativeCategory { Id = new Guid("2E7D719A-CEEF-415C-8C36-3C5FA8B6B199"), RelativeCategoryCode = "CHAU", RelativeCategoryName = "Cháu", SortOrder = 13 },
                new RelativeCategory { Id = new Guid("121F2A52-5321-4FAD-A055-D90841013C0F"), RelativeCategoryCode = "BAC_CHU_CAU", RelativeCategoryName = "Bác, chú, cậu", SortOrder = 14 },
                new RelativeCategory { Id = new Guid("A728A5C6-0F21-455E-8F7F-F2050312EF8F"), RelativeCategoryCode = "BAC_CO_DI", RelativeCategoryName = "Bác, cô, dì", SortOrder = 15 },
                new RelativeCategory { Id = new Guid("6ACE908E-6BBD-4974-B621-D617C5F87767"), RelativeCategoryCode = "KHAC", RelativeCategoryName = "Khác", SortOrder = 99 }
                );
        }
    }
}
