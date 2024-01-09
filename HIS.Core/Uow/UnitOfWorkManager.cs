using System.Transactions;

namespace HIS.Core.Uow
{
    public class UnitOfWorkManager : IUnitOfWorkManager
    {
        public IUnitOfWork Begin()
        {
            throw new NotImplementedException();
        }

        public IUnitOfWork Begin(TransactionScopeOption option)
        {
            throw new NotImplementedException();
        }
    }
}
