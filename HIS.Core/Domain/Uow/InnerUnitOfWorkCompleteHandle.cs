using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Domain.Uow
{
    /// <summary>
    /// UnitOfWork nằm trong 1 UnitOfWork khác.
    /// Không xử lý Complete() mà để UnitOfWork bên ngoài xử lý
    /// </summary>
    public class InnerUnitOfWorkCompleteHandle : IUnitOfWorkCompleteHandle
    {
        private volatile bool _isCompleteCalled;
        private volatile bool _isDisposed;

        public virtual void Complete()
        {
            _isCompleteCalled = true;
        }

        public virtual Task CompleteAsync()
        {
            _isCompleteCalled = true;
            return Task.FromResult(0);
        }

        public void Dispose()
        {
            if (_isDisposed)
            {
                return;
            }

            _isDisposed = true;

            if (!_isCompleteCalled)
            {
                if (HasException())
                {
                    return;
                }

                throw new Exception("Did not call Complete method of a unit of work.");
            }
        }

        private static bool HasException()
        {
            try
            {
                return Marshal.GetExceptionPointers() != 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
