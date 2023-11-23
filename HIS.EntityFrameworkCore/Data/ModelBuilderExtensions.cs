using HIS.EntityFrameworkCore.Data.Builders;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            ChapterIcdBuilder.Seed(modelBuilder);
            CountryBuilder.Seed(modelBuilder);
            UserBuilder.Seed(modelBuilder);
            ServiceGroupBuilder.Seed(modelBuilder);
            ServiceGroupHeInBuilder.Seed(modelBuilder);
            UnitBuilder.Seed(modelBuilder);
            SurgicalProcedureTypeBuilder.Seed(modelBuilder);
            DepartmentTypeBuilder.Seed(modelBuilder);
            RoomTypeBuilder.Seed(modelBuilder);
            ItemGroupBuilder.Seed(modelBuilder);
            ItemLineBuilder.Seed(modelBuilder);
            InOutStockTypeBuilder.Seed(modelBuilder);
            ProvinceBuilder.Seed(modelBuilder);
            GenderBuilder.Seed(modelBuilder);
            EthnicityBuilder.Seed(modelBuilder);
            
            
        }
    }
}
