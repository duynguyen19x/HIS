﻿using HIS.Core.Entities;
using HIS.EntityFrameworkCore.Configurations;
using HIS.EntityFrameworkCore.Data;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Items;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Reflection;

namespace HIS.EntityFrameworkCore
{
    public class HISDbContext : DbContext
    {
        public DbSet<Gender> Genders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<SToken> Tokens { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentType> DepartmentTypes { get; set; }
        public DbSet<Ethnic> Ethnicities { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Career> Careers { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Icd> Icds { get; set; }
        public DbSet<ChapterIcd> ChapterIcds { get; set; }
        public DbSet<RolePermissionBranch> RolePermissionBranchs { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceGroup> ServiceGroups { get; set; }
        public DbSet<ServiceGroupHeIn> ServiceGroupHeIns { get; set; }
        public DbSet<ServicePricePolicy> ServicePricePolicies { get; set; }
        public DbSet<SurgicalProcedureType> SurgicalProcedureTypes { get; set; }
        public DbSet<ExecutionRoom> ExecutionRooms { get; set; }
        public DbSet<ServiceResultIndice> ServiceResultIndices { get; set; }

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemGroup> ItemGroups { get; set; }
        public DbSet<ItemLine> ItemLines { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<ItemPricePolicy> ItemPricePolicies { get; set; }

        public DbSet<InOutStockType> InOutStockTypes { get; set; }
        public DbSet<ItemStock> ItemStocks { get; set; }
        public DbSet<InOutStock> InOutStocks { get; set; }
        public DbSet<InOutStockItem> InOutStockItems { get; set; }

        #region - hệ thống
        public DbSet<DbOption> DbOptions { get; set; }
        #endregion

        #region - danh mục

        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<BloodTypeRh> BloodTypeRhs { get; set; }
        public DbSet<Branch> Branchs { get; set; }
        public DbSet<DeathCause> DeathCauses { get; set; }
        public DbSet<DeathWithin> DeathWithins { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<MedicalRecordType> MedicalRecordTypes { get; set; }
        public DbSet<MedicalRecordTypeGroup> MedicalRecordTypeGroups { get; set; }
        public DbSet<National> Nationals { get; set; }
        public DbSet<PatientType> PatientTypes { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<ReceptionObjectType> ReceptionTypes { get; set; }
        public DbSet<RelativeType> RelativeTypes { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<RightRouteType> RightRouteTypes { get; set; }
        public DbSet<TreatmentEndType> TreatmentEndTypes { get; set; }
        public DbSet<TreatmentResult> TreatmentResults { get; set; }
        public DbSet<Ward> Wards { get; set; }

        #endregion

        #region - nghiệp vụ
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientRecord> PatientRecords { get; set; }
        public DbSet<PatientRecordStatus> PatientRecordStatuses { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<MedicalRecordStatus> MedicalRecordStatuses { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<ServiceRequestData> ServiceRequestDatas { get; set; }
        #endregion


        public HISDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.ApplyConfiguration();

            // load config
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Seed();
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
