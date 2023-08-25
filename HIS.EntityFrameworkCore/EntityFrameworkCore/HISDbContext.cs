using HIS.EntityFrameworkCore.Configurations;
using HIS.EntityFrameworkCore.Data;
using HIS.EntityFrameworkCore.Entities.Business;
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

        public DbSet<Gender> Genders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<SToken> Tokens { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Branch> Branchs { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentType> DepartmentTypes { get; set; }
        public DbSet<Ethnic> Ethnics { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Career> Careers { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Icd> Icds { get; set; }
        public DbSet<ChapterIcd> ChapterIcds { get; set; }
        public DbSet<RolePermissionBranch> RolePermissionBranchs { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialType> MaterialTypes { get; set; }
        public DbSet<PatientType> PatientTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<SWard> Wards { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceGroup> ServiceGroups { get; set; }
        public DbSet<ServiceGroupHeIn> ServiceGroupHeIns { get; set; }
        public DbSet<ServicePricePolicy> ServicePricePolicies { get; set; }
        public DbSet<SurgicalProcedureType> SurgicalProcedureTypes { get; set; }
        public DbSet<ExecutionRoom> ExecutionRooms { get; set; }
        public DbSet<ServiceResultIndice> ServiceResultIndices { get; set; }

        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<MedicineGroup> MedicineGroups { get; set; }
        public DbSet<MedicineLine> MedicineLines { get; set; }
        public DbSet<MedicineType> MedicineTypes { get; set; }
        public DbSet<MedicinePricePolicy> MedicinePricePolicies { get; set; }

        public DbSet<InOutStockType> InOutStockTypes { get; set; }
        public DbSet<MedicineStock> MedicineStocks { get; set; }
        public DbSet<InOutStock> InOutStocks { get; set; }
        public DbSet<InOutStockMedicine> InOutStockMedicines { get; set; }

        #region Patient
        public DbSet<HISPatient> Patients { get; set; }
        public DbSet<HISPatientRecord> PatientRecords { get; set; }
        #endregion

        #region System
        public DbSet<SYSAutoNumber> SYSAutoNumbers { get; set; }
        public DbSet<SYSRefType> SYSRefTypes { get; set; }
        public DbSet<SYSRefTypeCategory> SYSRefTypeCategories { get; set; }
        #endregion
    }
}
