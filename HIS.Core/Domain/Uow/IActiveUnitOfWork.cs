using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Domain.Uow
{
    public interface IActiveUnitOfWork
    {
        UnitOfWorkOptions Options { get; }
        bool IsDisposed { get; }

        void SaveChanges();
        Task SaveChangesAsync();

        event EventHandler Completed;
        event EventHandler Disposed;
    }
}
