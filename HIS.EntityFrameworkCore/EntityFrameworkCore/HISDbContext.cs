using HIS.EntityFrameworkCore.Configurations;
using HIS.EntityFrameworkCore.Data;
using HIS.EntityFrameworkCore.Entities.Business.Pharmaceuticals;
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

        public DbSet<Gender> SGenders { get; set; }
        public DbSet<User> SUsers { get; set; }
        public DbSet<Role> SRoles { get; set; }
        public DbSet<UserRole> SUserRoles { get; set; }
        public DbSet<SToken> STokens { get; set; }
        public DbSet<Permission> SPermissions { get; set; }
        public DbSet<Branch> SBranchs { get; set; }
        public DbSet<Department> SDepartments { get; set; }
        public DbSet<DepartmentType> SDepartmentTypes { get; set; }
        public DbSet<Ethnic> SEthnics { get; set; }
        public DbSet<Room> SRooms { get; set; }
        public DbSet<RoomType> SRoomTypes { get; set; }
        public DbSet<Career> SCareers { get; set; }
        public DbSet<Hospital> SHospitals { get; set; }
        public DbSet<Icd> SIcds { get; set; }
        public DbSet<ChapterIcd> SChapterIcds { get; set; }
        public DbSet<RolePermissionBranch> SRolePermissionBranchs { get; set; }
        public DbSet<Unit> SUnits { get; set; }
        public DbSet<Material> SMaterials { get; set; }
        public DbSet<MaterialType> SMaterialTypes { get; set; }
        public DbSet<PatientType> SPatientTypes { get; set; }
        public DbSet<Country> SCountries { get; set; }
        public DbSet<Province> SProvinces { get; set; }
        public DbSet<District> SDistricts { get; set; }
        public DbSet<SWard> SWards { get; set; }
        public DbSet<Supplier> SSuppliers { get; set; }

        public DbSet<Service> SServices { get; set; }
        public DbSet<ServiceGroup> SServiceGroups { get; set; }
        public DbSet<ServiceGroupHeIn> SServiceGroupHeIns { get; set; }
        public DbSet<ServicePricePolicy> SServicePricePolicies { get; set; }
        public DbSet<SurgicalProcedureType> SSurgicalProcedureTypes { get; set; }
        public DbSet<ExecutionRoom> SExecutionRooms { get; set; }
        public DbSet<ServiceResultIndice> SServiceResultIndices { get; set; }

        public DbSet<Medicine> SMedicines { get; set; }
        public DbSet<MedicineGroup> SMedicineGroups { get; set; }
        public DbSet<MedicineLine> SMedicineLines { get; set; }
        public DbSet<MedicineType> SMedicineTypes { get; set; }
        public DbSet<MedicinePricePolicy> SMedicinePricePolicies { get; set; }

        public DbSet<InOutStockType> InOutStockType { get; set; }
        public DbSet<MedicineStock> MedicineStocks { get; set; }
    }
}
