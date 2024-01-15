using Microsoft.Extensions.DependencyInjection;
using System.Transactions;

namespace HIS.Core.Domain.Uow
{
    public class UnitOfWorkManager : IUnitOfWorkManager
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ICurrentUnitOfWorkProvider _currentUnitOfWorkProvider;

        public IActiveUnitOfWork Current
        {
            get { return _currentUnitOfWorkProvider.Current; }
        }

        public UnitOfWorkManager(
            IServiceProvider serviceProvider,
            ICurrentUnitOfWorkProvider currentUnitOfWorkProvider) 
        {
            _serviceProvider = serviceProvider;
            _currentUnitOfWorkProvider = currentUnitOfWorkProvider;
        }

        public IUnitOfWorkCompleteHandle Begin()
        {
            return this.Begin(new UnitOfWorkOptions());
        }

        public IUnitOfWorkCompleteHandle Begin(TransactionScopeOption scope)
        {
            return Begin(new UnitOfWorkOptions { Scope = scope });
        }

        public IUnitOfWorkCompleteHandle Begin(UnitOfWorkOptions options)
        {
            if (options == null)
                options = new UnitOfWorkOptions();

            var outerUow = _currentUnitOfWorkProvider.Current;
            if (outerUow != null && options.Scope == TransactionScopeOption.Required)
            {
                return outerUow.Options?.Scope == TransactionScopeOption.Suppress
                    ? new InnerSuppressUnitOfWorkCompleteHandle(outerUow)
                    : new InnerUnitOfWorkCompleteHandle();
            }

            var uow = _serviceProvider.GetService<IUnitOfWork>();
            uow.Completed += (sender, args) =>
            {
                _currentUnitOfWorkProvider.Current = null;
            };

            uow.Begin(options);
            _currentUnitOfWorkProvider.Current = uow;
            return uow;
        }

        
    }
}
