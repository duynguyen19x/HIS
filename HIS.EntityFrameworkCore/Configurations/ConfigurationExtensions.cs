using HIS.EntityFrameworkCore.Configurations.Business;
using HIS.EntityFrameworkCore.Configurations.Dictionaries;
using HIS.EntityFrameworkCore.Configurations.Items;
using HIS.EntityFrameworkCore.Configurations.Services;
using HIS.EntityFrameworkCore.Configurations.Systems;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.Configurations
{
    public static class ConfigurationExtensions
    {
        public static void ApplyConfiguration(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfigurations());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new TokenConfiguration());
            modelBuilder.ApplyConfiguration(new GenderConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfigurations());
            modelBuilder.ApplyConfiguration(new BranchConfiguration());
            modelBuilder.ApplyConfiguration(new CareerConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new RoomTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new RolePermissionBranchConfigurations());
            modelBuilder.ApplyConfiguration(new UnitConfigurations());
            modelBuilder.ApplyConfiguration(new ServiceConfigurations());
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new ItemGroupConfiguration());
            modelBuilder.ApplyConfiguration(new ItemLineConfiguration());
            modelBuilder.ApplyConfiguration(new ItemTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new ProvinceConfiguration());
            modelBuilder.ApplyConfiguration(new DistrictConfiguration());
            modelBuilder.ApplyConfiguration(new WardConfiguration());
            modelBuilder.ApplyConfiguration(new IcdConfiguration());
            modelBuilder.ApplyConfiguration(new ChapterIcdConfigurations());
            modelBuilder.ApplyConfiguration(new ServicePricePolicyConfigurations());
            modelBuilder.ApplyConfiguration(new ItemPricePolicyConfigurations());
            modelBuilder.ApplyConfiguration(new SurgicalProcedureTypeConfigurations());
            modelBuilder.ApplyConfiguration(new EthnicConfiguration());
            modelBuilder.ApplyConfiguration(new HospitalConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceGroupConfigurations());
            modelBuilder.ApplyConfiguration(new ServiceGroupHeInConfigurations());
            modelBuilder.ApplyConfiguration(new ServiceResultIndexConfiguration());
            modelBuilder.ApplyConfiguration(new ExecutionRoomConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());

            modelBuilder.ApplyConfiguration(new InOutStockTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ItemStockConfiguration());
            modelBuilder.ApplyConfiguration(new InOutStockItemConfiguration());
            modelBuilder.ApplyConfiguration(new InOutStockConfiguration());

            modelBuilder.ApplyConfiguration(new PatientTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new PatientRecordConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalRecordConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalRecordEndTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalRecordResultConfiguration());
            modelBuilder.ApplyConfiguration(new PatientRecordTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalRecordTypeConfiguration());

            modelBuilder.ApplyConfiguration(new InsuranceConfiguration());
            modelBuilder.ApplyConfiguration(new ReceptionTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceRequestConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceRequestServeConfiguration());
            modelBuilder.ApplyConfiguration(new DbOptionConfigurations());
        }
    }
}
