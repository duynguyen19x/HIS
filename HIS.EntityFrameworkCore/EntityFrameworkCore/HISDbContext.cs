using HIS.EntityFrameworkCore.Configurations;
using HIS.EntityFrameworkCore.Configurations.Business;
using HIS.EntityFrameworkCore.Configurations.Business.Pharmaceuticals;
using HIS.EntityFrameworkCore.Configurations.Dictionaries;
using HIS.EntityFrameworkCore.Configurations.Medicines;
using HIS.EntityFrameworkCore.Configurations.Patients;
using HIS.EntityFrameworkCore.Configurations.Services;
using HIS.EntityFrameworkCore.Data;
using HIS.EntityFrameworkCore.Entities.Business.Patients;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals.ImpMests;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Medicines;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace HIS.EntityFrameworkCore.EntityFrameworkCore
{
    public class HISDbContext : DbContext
    {
        public HISDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration();
            modelBuilder.Seed();
        }

        public virtual IDbContextTransaction BeginTransaction()
        {
            return Database.BeginTransaction();
        }

        public DbSet<SGender> SGenders { get; set; }
        public DbSet<SUser> SUsers { get; set; }
        public DbSet<SRole> SRoles { get; set; }
        public DbSet<SUserRole> SUserRoles { get; set; }
        public DbSet<SToken> STokens { get; set; }
        public DbSet<SPermission> SPermissions { get; set; }
        public DbSet<SBranch> SBranchs { get; set; }
        public DbSet<SDepartment> SDepartments { get; set; }
        public DbSet<SDepartmentType> SDepartmentTypes { get; set; }
        public DbSet<SEthnic> SEthnics { get; set; }
        public DbSet<SRoom> SRooms { get; set; }
        public DbSet<SRoomType> SRoomTypes { get; set; }
        public DbSet<SCareer> SCareers { get; set; }
        public DbSet<SHospital> SHospitals { get; set; }
        public DbSet<SIcd> SIcds { get; set; }
        public DbSet<SRolePermissionBranch> SRolePermissionBranchs { get; set; }
        public DbSet<SUnit> SUnits { get; set; }
        public DbSet<SMaterial> SMaterials { get; set; }
        public DbSet<SMaterialType> SMaterialTypes { get; set; }
        public DbSet<SPatient> SPatients { get; set; }
        public DbSet<STreatment> STreatments { get; set; }
        public DbSet<SPatientType> SPatientTypes { get; set; }
        public DbSet<SCountry> SCountries { get; set; }
        public DbSet<SProvince> SProvinces { get; set; }
        public DbSet<SDistrict> SDistricts { get; set; }
        public DbSet<SWard> SWards { get; set; }
        public DbSet<SSupplier> SSuppliers { get; set; }

        public DbSet<SService> SServices { get; set; }
        public DbSet<SServiceGroup> SServiceGroups { get; set; }
        public DbSet<SServiceGroupHeIn> SServiceGroupHeIns { get; set; }
        public DbSet<SServicePricePolicy> SServicePricePolicies { get; set; }
        public DbSet<SSurgicalProcedureType> SSurgicalProcedureTypes { get; set; }
        public DbSet<SExecutionRoom> SExecutionRooms { get; set; }
        public DbSet<SServiceResultIndice> SServiceResultIndices { get; set; }

        public DbSet<SMedicine> SMedicines { get; set; }
        public DbSet<SMedicineGroup> SMedicineGroups { get; set; }
        public DbSet<SMedicineLine> SMedicineLines { get; set; }
        public DbSet<SMedicineType> SMedicineTypes { get; set; }
        public DbSet<SMedicinePricePolicy> SMedicinePricePolicies { get; set; }

        public DbSet<DImpExpMestType> DImpExpMestTypes { get; set; }
        public DbSet<DImpMest> DImpMests { get; set; }
        public DbSet<DImpMestMedicine> DImpMestMedicines { get; set; }
        public DbSet<DMedicineStock> DMedicineStocks { get; set; }
    }
}
