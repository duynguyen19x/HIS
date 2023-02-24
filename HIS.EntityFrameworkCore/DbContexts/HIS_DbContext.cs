using HIS.EntityFrameworkCore.Configurations;
using HIS.EntityFrameworkCore.Data;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new RolePermissionBranchConfigurations());
            modelBuilder.ApplyConfiguration(new ServiceUnitConfigurations());
            modelBuilder.ApplyConfiguration(new ServiceTypeConfigurations());
            modelBuilder.ApplyConfiguration(new ServiceConfigurations());

            modelBuilder.Seed();
        }
        
        public DbSet<SGender> SGenders { get; set; }
        public DbSet<SUser> SUsers { get; set; }
        public DbSet<SRole> SRoles { get; set; }
        public DbSet<SUserRole> SUserRoles { get; set; }
        public DbSet<SToken> STokens { get; set; }
        public DbSet<SPermission> SPermissions { get; set; }
        public DbSet<SBranch> SBranchs { get; set; }
        public DbSet<SRolePermissionBranch> SRolePermissionBranchs { get; set; }
        public DbSet<SService> SServices { get; set; }
        public DbSet<SServiceType> SServiceTypes { get; set; }
        public DbSet<SServiceUnit> SServiceUnits { get; set; }
    }
}
