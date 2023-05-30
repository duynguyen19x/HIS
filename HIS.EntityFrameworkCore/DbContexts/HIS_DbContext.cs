﻿using HIS.EntityFrameworkCore.Configurations;
using HIS.EntityFrameworkCore.Configurations.Dictionaries;
using HIS.EntityFrameworkCore.Configurations.Patients;
using HIS.EntityFrameworkCore.Configurations.Services;
using HIS.EntityFrameworkCore.Data;
using HIS.EntityFrameworkCore.Entities.Business.Patients;
using HIS.EntityFrameworkCore.Entities.Business.Treatment;
using HIS.EntityFrameworkCore.Entities.Categories;
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
            modelBuilder.ApplyConfiguration(new CareerConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new RoomTypeConfiguration());
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
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new ProvinceConfiguration());
            modelBuilder.ApplyConfiguration(new DistrictConfiguration());
            modelBuilder.ApplyConfiguration(new WardConfiguration());
            modelBuilder.ApplyConfiguration(new PricePolicyConfigurations());
            modelBuilder.ApplyConfiguration(new ServicePricePolicyConfigurations());

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
        public DbSet<SDepartmentType> SDepartmentTypes { get; set; }
        public DbSet<SEthnic> SEthnics { get; set; }
        public DbSet<SRoom> SRooms { get; set; }
        public DbSet<SRoomType> SRoomTypes { get; set; }
        public DbSet<SCareer> SCareers { get; set; }
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
        public DbSet<STreatment> STreatments { get; set; }
        public DbSet<SPatientType> SPatientTypes { get; set; }
        public DbSet<SCountry> SCountries { get; set; }
        public DbSet<SProvince> SProvinces { get; set; }
        public DbSet<SDistrict> SDistricts { get; set; }
        public DbSet<SWard> SWards { get; set; }
    }
}
