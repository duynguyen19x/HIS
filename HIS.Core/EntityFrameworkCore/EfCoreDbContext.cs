using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Entities.Auditing;
using HIS.Core.Extensions;
using HIS.Core.Runtime.Session;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.EntityFrameworkCore
{
    /// <summary>
    /// Base class for all DbContext classes in the application.
    /// </summary>
    public abstract class EfCoreDbContext : DbContext
    {
        public IAppSession AppSession { get; set; }

        public EfCoreDbContext(DbContextOptions options)
            : base(options) 
        { 
            AppSession = NullAppSession.Instance;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                ConfigureKeys(modelBuilder, entityType);
                ConfigureGlobalFilters(modelBuilder, entityType);
            }     
        }

        protected virtual void ConfigureKeys(ModelBuilder modelBuilder, IMutableEntityType entityType)
        {
            var entityTypeBuilder = modelBuilder.Entity(entityType.ClrType);

            // đặt khóa chính với kiểu dữ liệu xác định
            if (typeof(IEntity<>).IsAssignableFrom(entityType.ClrType))
            {
                entityTypeBuilder.HasKey("Id");
                //entityTypeBuilder.Property("Id").ValueGeneratedOnAdd();
            }
            //else if (typeof(IEntity).IsAssignableFrom(entityType.ClrType) && entityType.FindProperty(entityType.Name + "Id") != null)
            //{
            //    entityTypeBuilder.HasKey(entityType.Name + "Id");
            //}    


        }

        protected virtual void ConfigureGlobalFilters(ModelBuilder modelBuilder, IMutableEntityType entityType)
        {
            // loại bỏ các cột có trạng thái là đã xóa (IsDeleted).
            if (typeof(ISoftDelete).IsAssignableFrom(entityType.ClrType))
            {
                entityType.AddSoftDeleteQueryFilter();
            }    
        }

        public override int SaveChanges()
        {
            ApplyConcepts();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ApplyConcepts();
            return base.SaveChangesAsync(cancellationToken);
        }

        protected virtual void ApplyConcepts()
        {
            var userId = GetAuditUserId();

            foreach (EntityEntry entry in ChangeTracker.Entries().ToList())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        {
                            if (entry.Entity is ICreationAudited creation)
                            {
                                if (Check.IsNullOrDefault(creation.CreatedBy))
                                    creation.CreatedBy = userId;
                                if (Check.IsNullOrDefault(creation.CreatedDate))
                                    creation.CreatedDate = DateTime.Now;
                            }    
                            break;
                        }
                    case EntityState.Modified:
                        {
                            if (entry.Entity is IAudited audited)
                            {
                                if (Check.IsNullOrDefault(audited.ModifiedBy))
                                    audited.ModifiedBy = userId;
                                if (Check.IsNullOrDefault(audited.ModifiedDate))
                                    audited.ModifiedDate = DateTime.Now;
                            }
                            break;
                        }
                    case EntityState.Deleted:
                        {
                            if (entry.Entity is ISoftDelete delete)
                            {
                                entry.Reload();
                                entry.State = EntityState.Modified;
                                delete.IsDeleted = true;
                                if (Check.IsNullOrDefault(delete.DeletedBy)) // neu chua co audit thi them vao
                                    delete.DeletedBy = userId;
                                if (Check.IsNullOrDefault(delete.DeletedDate))
                                    delete.DeletedDate = DateTime.Now;
                            } 
                            break;
                        }
                }
            }
        }

        protected virtual Guid? GetAuditUserId()
        {
            return AppSession.UserId;
        }
    }
}
