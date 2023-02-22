using HIS.EntityFrameworkCore.Configurations;
using HIS.EntityFrameworkCore.Data;
using HIS.EntityFrameworkCore.Entities.Categories;
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

            modelBuilder.Seed();
        }
        
        public DbSet<SGender> Genders { get; set; }
        public DbSet<SUser> Users { get; set; }
        public DbSet<SRole> Roles { get; set; }
        public DbSet<SUserRole> UserRoles { get; set; }
        public DbSet<SToken> Tokens { get; set; }
        public DbSet<SPermission> Permissions { get; set; }
        public DbSet<SBranch> Branchs { get; set; }
        public DbSet<SRolePermissionBranch> RolePermissionBranchs { get; set; }
    }
}
