using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionary
{
    public class CareerConfiguration : IEntityTypeConfiguration<Career>
    {
        public void Configure(EntityTypeBuilder<Career> builder)
        {
            builder.HasData(
                new Career() { Id = new Guid("343E6492-50E0-4F84-B323-A9411196E694"), Code = "1", Name = "Nông dân", SortOrder = 1 },
                new Career() { Id = new Guid("9F21B51A-DD3B-4F22-B3B5-E3D6B59107AE"), Code = "2", Name = "Lực lượng vũ trang", SortOrder = 2 },
                new Career() { Id = new Guid("27F97033-2472-46B2-AD8A-763039CAC120"), Code = "3", Name = "Trẻ dưới 6 tuổi đi học, dưới 15 tuổi không đi học", SortOrder = 3 },
                new Career() { Id = new Guid("343E6492-50E0-4F84-B323-A9411196E695"), Code = "4", Name = "Sinh viên, học sinh", SortOrder = 4 },
                new Career() { Id = new Guid("343E6492-50E0-4F84-B323-A9411196E696"), Code = "5", Name = "Công nhân", SortOrder = 5 },
                new Career() { Id = new Guid("343E6492-50E0-4F84-B323-A9411196E697"), Code = "6", Name = "Trí thức", SortOrder = 6 },
                new Career() { Id = new Guid("508AB49B-78A7-47FE-B5C9-E06589FB8126"), Code = "7", Name = "Hành chính, sự nghiệp", SortOrder = 7 },
                new Career() { Id = new Guid("E17526D6-1AE3-4649-86BE-E143474D3A89"), Code = "8", Name = "Y tế", SortOrder = 8 },
                new Career() { Id = new Guid("A373A40C-5097-4716-B683-4A5C3B69FE6E"), Code = "9", Name = "Dịch vụ", SortOrder = 9 },
                new Career() { Id = new Guid("A373A40C-5097-4716-B683-4A5C3B69FE7E"), Code = "10", Name = "Ngoại kiều", SortOrder = 10 },
                new Career() { Id = new Guid("855DED87-0521-4322-93F5-69E36E3A89D8"), Code = "11", Name = "Nhân dân", SortOrder = 11 },
                new Career() { Id = new Guid("824AF7E8-3526-4B6F-9005-BF0FDE1974A8"), Code = "12", Name = "Giáo viên", SortOrder = 12 },
                new Career() { Id = new Guid("2BEBF89A-F496-4DA5-AABB-787C4DCA82A7"), Code = "13", Name = "Thương binh", SortOrder = 13 },
                new Career() { Id = new Guid("43D31DA7-5889-4FBD-94CB-4800507AC9D8"), Code = "14", Name = "Kế toán", SortOrder = 14 },
                new Career() { Id = new Guid("89BC4BCA-F38B-4808-A64D-325B03DC240C"), Code = "15", Name = "Khác", SortOrder = 15 }
                );
        }
    }
}
