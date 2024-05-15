using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Entities.Auditing;
using HIS.Core.EntityFrameworkCore;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Configurations;
using HIS.EntityFrameworkCore.Entities;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Items;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using HIS.EntityFrameworkCore.Entities.System;
using HIS.EntityFrameworkCore.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;

namespace HIS.EntityFrameworkCore
{
    public class HISDbContext : EfCoreDbContext //DbContext
    {
        public HISDbContext(DbContextOptions options) 
            : base(options) { }

        #region - Hệ thống

        public DbSet<DbOption> DbOptions { get; set; }

        public DbSet<Option> Option { get; set; }
        public DbSet<OptionCategory> OptionCategory { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<ReportCategory> ReportCategory { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<UserRoleMapping> UserRoleMapping { get; set; }
        public DbSet<UserRoomMapping> UserRoomMapping { get; set; }
        public DbSet<RolePermissionMapping> RolePermissionMapping { get; set; }
        public DbSet<UserToken> Tokens { get; set; }

        

        #endregion

        #region - Danh mục

        public DbSet<BirthCertBook> BirthCertBook { get; set; }
        public DbSet<BloodType> BloodType { get; set; }
        public DbSet<BloodRhType> BloodTypeRh { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Career> Career { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<ChapterIcd> ChapterIcd { get; set; }
        public DbSet<DeathCause> DeathCause { get; set; }
        public DbSet<DeathCertBook> DeathCertBook { get; set; }
        public DbSet<DeathWithin> DeathWithin { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<DepartmentType> DepartmentType { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Ethnicity> Ethnicity { get; set; }
        public DbSet<ExecutionRoom> ExecutionRoom { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Hospital> Hospital { get; set; }
        public DbSet<Icd> Icd { get; set; }
        public DbSet<InvoiceGroup> InvoiceGroup { get; set; }
        public DbSet<InvoiceGroupBelongToUser> InvoiceGroupBelongToUser { get; set; }
        public DbSet<InvoiceType> InvoiceType { get; set; }
        public DbSet<LiveArea> LiveArea { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<MedicalRecordType> MedicalRecordType { get; set; }
        public DbSet<MedicalRecordTypeGroup> MedicalRecordTypeGroup { get; set; }
        public DbSet<PatientObjectType> PatientObjectType { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<ReceptionObjectType> ReceptionObjectType { get; set; }
        public DbSet<Relationship> Relationship { get; set; }
        public DbSet<Religion> Religion { get; set; }
        public DbSet<RightRouteType> RightRouteType { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<TreatmentEndType> TreatmentEndType { get; set; }
        public DbSet<TreatmentResultType> TreatmentResult { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<Ward> Ward { get; set; }
        
        
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceGroup> ServiceGroups { get; set; }
        public DbSet<ServiceGroupHeIn> ServiceGroupHeIns { get; set; }
        public DbSet<ServicePricePolicy> ServicePricePolicies { get; set; }
        public DbSet<SurgicalProcedureType> SurgicalProcedureTypes { get; set; }
        public DbSet<ServiceResultIndice> ServiceResultIndices { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemGroup> ItemGroups { get; set; }
        public DbSet<ItemLine> ItemLines { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<ItemPricePolicy> ItemPricePolicies { get; set; }

        #endregion

        #region - Nghiệp vụ

        public DbSet<Insurance> Insurance { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<PatientRecord> PatientRecord { get; set; }
        
        public DbSet<Entities.Business.ServiceRequest> ServiceRequests { get; set; }
        public DbSet<ServiceRequestData> ServiceRequestDatas { get; set; }
        public DbSet<ServiceResultData> ServiceResultDatas { get; set; }

        public DbSet<InOutStockType> InOutStockTypes { get; set; }
        public DbSet<ItemStock> ItemStocks { get; set; }
        public DbSet<InOutStock> InOutStocks { get; set; }
        public DbSet<InOutStockItem> InOutStockItems { get; set; }
        #endregion

        #region - Views
        public DbSet<ServiceRequestView> ServiceRequestViews { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Load config
            builder.ApplyConfiguration();

            // Add View
            builder.Entity<ServiceRequestView>().ToView("V_BUS_ServiceRequest");
        }


        public virtual IDbContextTransaction BeginTransaction()
        {
            return Database.BeginTransaction();
        }

        public virtual int NewID<TEntity>() where TEntity : class, IEntity<int>
        {
            var dbSet = this.Set<TEntity>();
            var data = dbSet.DefaultIfEmpty().Max(x => x.Id);
            return data + 1;
        }
    }
}
