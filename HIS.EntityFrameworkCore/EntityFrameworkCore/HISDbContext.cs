﻿using HIS.EntityFrameworkCore.Configurations;
using HIS.EntityFrameworkCore.Data;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Items;
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
        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<ReceptionType> ReceptionTypes { get; set; }
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

        public DbSet<Item> Items { get; set; }
        public DbSet<ItemGroup> ItemGroups { get; set; }
        public DbSet<ItemLine> ItemLines { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<ItemPricePolicy> ItemPricePolicies { get; set; }

        public DbSet<InOutStockType> InOutStockTypes { get; set; }
        public DbSet<ItemStock> ItemStocks { get; set; }
        public DbSet<InOutStock> InOutStocks { get; set; }
        public DbSet<InOutStockItem> InOutStockItems { get; set; }

        public DbSet<DeathCause> DeathCauses { get; set; }
        public DbSet<DeathWithin> DeathWithins { get; set; }
        public DbSet<PatientType> PatientTypes { get; set; }
        public DbSet<PatientRecordType> PatientRecordTypes { get; set; }
        public DbSet<MedicalRecordType> MedicalRecordTypes { get; set; }
        public DbSet<MedicalRecordResult> MedicalRecordResults { get; set; }
        public DbSet<MedicalRecordEndType> MedicalRecordEndTypes { get; set; }

        #region - danh mục
        public DbSet<ColumnTemplate> ColumnTemplates { get; set; }
        #endregion

        #region Patient
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientRecord> PatientRecords { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Treatment> Treatments { get; set; }

        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<ServiceRequestServe> ServiceRequestServes { get; set; }
        #endregion

        #region System
        public DbSet<SYSAutoNumber> SYSAutoNumbers { get; set; }
        public DbSet<SYSRefType> SYSRefTypes { get; set; }
        public DbSet<SYSRefTypeCategory> SYSRefTypeCategories { get; set; }
        #endregion
    }
}
