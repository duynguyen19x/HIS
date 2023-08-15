using HIS.EntityFrameworkCore.Data.Builders;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            GenderBuilder.Seed(modelBuilder);
            UserBuilder.Seed(modelBuilder);
            ServiceGroupBuilder.Seed(modelBuilder);
            ServiceGroupHeInBuilder.Seed(modelBuilder);
            UnitBuilder.Seed(modelBuilder);
            PatientTypeBuilder.Seed(modelBuilder);
            SurgicalProcedureTypeBuilder.Seed(modelBuilder);
            DepartmentTypeBuilder.Seed(modelBuilder);
            RoomTypeBuilder.Seed(modelBuilder);
            MedicineGroupBuilder.Seed(modelBuilder);
            MedicineLineBuilder.Seed(modelBuilder);
            SCountryBuilder.Seed(modelBuilder);
            ChapterIcdBuilder.Seed(modelBuilder);
            ImpExpMestTypeBuilder.Seed(modelBuilder);
        }
    }
}
