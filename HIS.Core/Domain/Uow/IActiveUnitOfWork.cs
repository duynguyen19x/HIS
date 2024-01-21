using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Domain.Uow
{
    public interface IActiveUnitOfWork
    {
        /// <summary>
        /// Sự kiện được gọi khi UOW xử lý hoàn thành.
        /// </summary>
        event EventHandler Completed;

        /// <summary>
        /// Sự kiện được gọi khi UOW kết thúc xử lý.
        /// </summary>
        event EventHandler Disposed;

        /// <summary>
        /// Gets if this unit of work is transactional.
        /// </summary>
        UnitOfWorkOptions Options { get; }

        /// <summary>
        /// Is this UOW disposed?
        /// </summary>
        bool IsDisposed { get; }

        void SaveChanges();

        Task SaveChangesAsync();
    }
}
