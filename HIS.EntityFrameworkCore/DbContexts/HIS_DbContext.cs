using HIS.EntityFrameworkCore.Configurations;
using HIS.EntityFrameworkCore.Configurations.Dictionaries;
using HIS.EntityFrameworkCore.Configurations.Others;
using HIS.EntityFrameworkCore.Configurations.Patients;
using HIS.EntityFrameworkCore.Data;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Others;
using HIS.EntityFrameworkCore.Entities.Categories.Patients;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.DbContexts
{
    public class HIS_DbContext : DbContext
    {
        public HIS_DbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new GenderConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfigurations());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new TokenConfiguration());
            modelBuilder.ApplyConfiguration(new GenderConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfigurations());
            modelBuilder.ApplyConfiguration(new BranchConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new RolePermissionBranchConfigurations());
            modelBuilder.ApplyConfiguration(new ServiceUnitConfigurations());
            modelBuilder.ApplyConfiguration(new ServiceTypeConfigurations());
            modelBuilder.ApplyConfiguration(new ServiceConfigurations());
            modelBuilder.ApplyConfiguration(new MedicineConfiguration());
            modelBuilder.ApplyConfiguration(new MedicineGroupConfiguration());
            modelBuilder.ApplyConfiguration(new MedicineLineConfiguration());
            modelBuilder.ApplyConfiguration(new MedicineTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new PatientTypeConfiguration());
            modelBuilder.ApplyConfiguration(new NationalConfiguration());
            modelBuilder.ApplyConfiguration(new ProvinceConfiguration());
            modelBuilder.ApplyConfiguration(new DistrictConfiguration());
            modelBuilder.ApplyConfiguration(new CommuneConfiguration());

            modelBuilder.Seed();
        }

        public DbSet<SGender> SGenders { get; set; }
        public DbSet<SUser> SUsers { get; set; }
        public DbSet<SRole> SRoles { get; set; }
        public DbSet<SUserRole> SUserRoles { get; set; }
        public DbSet<SToken> STokens { get; set; }
        public DbSet<SPermission> SPermissions { get; set; }
        public DbSet<SBranch> SBranchs { get; set; }
        public DbSet<SDepartment> SDepartments { get; set; }
        public DbSet<SEthnic> SEthnics { get; set; }
        public DbSet<SRoom> SRooms { get; set; }
        public DbSet<SJob> SJobs { get; set; }
        public DbSet<SHospital> SHospitals { get; set; }
        public DbSet<SIcd> SIcds { get; set; }

        public DbSet<SRolePermissionBranch> SRolePermissionBranchs { get; set; }
        public DbSet<SService> SServices { get; set; }
        public DbSet<SServiceType> SServiceTypes { get; set; }
        public DbSet<SServiceUnit> SServiceUnits { get; set; }
        public DbSet<SMedicine> SMedicines { get; set; }
        public DbSet<SMedicineGroup> SMedicineGroups { get; set; }
        public DbSet<SMedicineLine> SMedicineLines { get; set; }
        public DbSet<SMedicineType> SMedicineTypes { get; set; }
        public DbSet<SMaterial> SMaterials { get; set; }
        public DbSet<SMaterialType> SMaterialTypes { get; set; }
        public DbSet<SPatient> SPatients { get; set; }
        public DbSet<SPatientType> SPatientTypes { get; set; }
        public DbSet<SNational> SNationals { get; set; }
        public DbSet<SProvince> SProvinces { get; set; }
        public DbSet<SDistrict> SDistricts { get; set; }
        public DbSet<SCommune> SCommunes { get; set; }
    }
}
