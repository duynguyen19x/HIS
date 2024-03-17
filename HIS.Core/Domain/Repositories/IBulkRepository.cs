using EFCore.BulkExtensions;
using HIS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Domain.Repositories
{
    public interface IBulkRepository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        public void BulkDelete(IList<TEntity> entities, BulkConfig bulkConfig = null, Action<decimal> progress = null, Type type = null);

        public void BulkDelete(IList<TEntity> entities, Action<BulkConfig> bulkAction = null, Action<decimal> progress = null, Type type = null);

        public Task BulkDeleteAsync(IList<TEntity> entities, Action<BulkConfig> bulkAction = null, Action<decimal> progress = null, Type type = null, CancellationToken cancellationToken = default);

        public Task BulkDeleteAsync(IList<TEntity> entities, BulkConfig bulkConfig = null, Action<decimal> progress = null, Type type = null, CancellationToken cancellationToken = default);

        public void BulkInsert(IList<TEntity> entities, BulkConfig bulkConfig = null, Action<decimal> progress = null, Type type = null);

        public void BulkInsert(IList<TEntity> entities, Action<BulkConfig> bulkAction = null, Action<decimal> progress = null, Type type = null);

        public Task BulkInsertAsync(IList<TEntity> entities, Action<BulkConfig> bulkAction = null, Action<decimal> progress = null, Type type = null, CancellationToken cancellationToken = default);

        public Task BulkInsertAsync(IList<TEntity> entities, BulkConfig bulkConfig = null, Action<decimal> progress = null, Type type = null, CancellationToken cancellationToken = default);

        public void BulkInsertOrUpdate(IList<TEntity> entities, BulkConfig bulkConfig = null, Action<decimal> progress = null, Type type = null);

        public void BulkInsertOrUpdate(IList<TEntity> entities, Action<BulkConfig> bulkAction = null, Action<decimal> progress = null, Type type = null);

        public Task BulkInsertOrUpdateAsync(IList<TEntity> entities, Action<BulkConfig> bulkAction = null, Action<decimal> progress = null, Type type = null);

        public Task BulkInsertOrUpdateAsync(IList<TEntity> entities, BulkConfig bulkConfig = null, Action<decimal> progress = null, Type type = null);

        public void BulkInsertOrUpdateOrDelete(IList<TEntity> entities, BulkConfig bulkConfig = null, Action<decimal> progress = null, Type type = null);

        public void BulkInsertOrUpdateOrDelete(IList<TEntity> entities, Action<BulkConfig> bulkAction = null, Action<decimal> progress = null, Type type = null);

        public Task BulkInsertOrUpdateOrDeleteAsync(IList<TEntity> entities, Action<BulkConfig> bulkAction = null, Action<decimal> progress = null, Type type = null);

        public Task BulkInsertOrUpdateOrDeleteAsync(IList<TEntity> entities, BulkConfig bulkConfig = null, Action<decimal> progress = null, Type type = null);

        public void BulkRead(IList<TEntity> entities, BulkConfig bulkConfig = null, Action<decimal> progress = null, Type type = null);

        public void BulkRead(IList<TEntity> entities, Action<BulkConfig> bulkAction = null, Action<decimal> progress = null, Type type = null);

        public Task BulkReadAsync(IList<TEntity> entities, Action<BulkConfig> bulkAction = null, Action<decimal> progress = null, Type type = null);

        public Task BulkReadAsync(IList<TEntity> entities, BulkConfig bulkConfig = null, Action<decimal> progress = null, Type type = null);

        public void BulkUpdate(IList<TEntity> entities, BulkConfig bulkConfig = null, Action<decimal> progress = null, Type type = null);

        public void BulkUpdate(IList<TEntity> entities, Action<BulkConfig> bulkAction = null, Action<decimal> progress = null, Type type = null);

        public Task BulkUpdateAsync(IList<TEntity> entities, Action<BulkConfig> bulkAction = null, Action<decimal> progress = null, Type type = null);

        public Task BulkUpdateAsync(IList<TEntity> entities, BulkConfig bulkConfig = null, Action<decimal> progress = null, Type type = null);

        public void Truncate(Type type = null);

        public Task Truncate(Type type = null, CancellationToken cancellationToken = default);
    }
}
