using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using System.Transactions;
using HIS.Core.EntityFrameworkCore;

namespace HIS.Core.Domain.Uow
{
    public class UnitOfWork<TDbContext> : IUnitOfWork
        where TDbContext : DbContext
    {
        private bool _isBeginCalledBefore;
        private bool _isCompleteCalledBefore;
        private bool _succeed;
        private Exception _exception;

        public event EventHandler Completed;

        public event EventHandler Disposed;

        protected IDbContextProvider<TDbContext> DbContextProvider { get; }

        public string Id { get; }

        public IUnitOfWork Outer { get; set; }

        public bool IsDisposed { get; private set; }

        public UnitOfWorkOptions Options { get; set; }

        protected TransactionScope CurrentTransaction { get; set; }


        public UnitOfWork(IDbContextProvider<TDbContext> dbContextProvider)
        {
            DbContextProvider = dbContextProvider;
            Id = Guid.NewGuid().ToString("N");
        }


        public void Begin(UnitOfWorkOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            PreventMultipleBegin();
            Options = options;

            BeginUow();
        }

        public void Complete()
        {
            PreventMultipleComplete();
            try
            {
                CompleteUow();
                _succeed = true;
                OnCompleted();
            }
            catch (Exception ex)
            {
                _exception = ex;
                throw;
            }
        }

        public async Task CompleteAsync()
        {
            PreventMultipleComplete();
            try
            {
                await CompleteUowAsync();
                _succeed = true;
                OnCompleted();
            }
            catch (Exception ex)
            {
                _exception = ex;
                throw;
            }
        }

        public void SaveChanges()
        {
            DbContextProvider.GetDbContext().SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await DbContextProvider.GetDbContext().SaveChangesAsync();
        }

        public void Dispose()
        {
            if (!_isBeginCalledBefore || IsDisposed)
            {
                return;
            }

            IsDisposed = true;

            DisposeUow();
            OnDisposed();
        }


        public virtual void BeginUow()
        {
            var transactionOptions = new TransactionOptions();
            transactionOptions.IsolationLevel = Options.IsolationLevel.GetValueOrDefault(IsolationLevel.ReadUncommitted);

            if (Options.Timeout.HasValue)
            {
                transactionOptions.Timeout = Options.Timeout.Value;
            }

            CurrentTransaction = new TransactionScope(
                Options.Scope.GetValueOrDefault(TransactionScopeOption.Required),
                transactionOptions,
                Options.AsyncFlowOption.GetValueOrDefault(TransactionScopeAsyncFlowOption.Enabled)
            );
        }

        public virtual void CompleteUow()
        {
            SaveChanges();

            if (CurrentTransaction != null)
            {
                CurrentTransaction.Complete();
            }
        }

        public virtual async Task CompleteUowAsync()
        {
            await SaveChangesAsync();

            if (CurrentTransaction != null)
            {
                CurrentTransaction.Complete();
            }
        }

        public virtual void DisposeUow()
        {
            if (CurrentTransaction != null)
            {
                CurrentTransaction.Dispose();
                if (_succeed)
                {

                }
            }
        }


        protected virtual void OnCompleted()
        {
            if (Completed == null)
            {
                Completed(this, EventArgs.Empty);
            }
        }

        protected virtual void OnDisposed()
        {
            if (Disposed != null)
            {
                Disposed(this, EventArgs.Empty);
            }
        }


        private void PreventMultipleBegin()
        {
            if (_isBeginCalledBefore)
                throw new Exception("This unit of work has started before. Can not call Start method more than once.");

            _isBeginCalledBefore = true;
        }

        private void PreventMultipleComplete()
        {
            if (_isCompleteCalledBefore)
                throw new Exception("Complete is called before!");

            _isCompleteCalledBefore = true;
        }

    }
}
