using System.Transactions;

namespace HIS.Core.Uow
{
    public class UnitOfWorkManager : IUnitOfWorkManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public IUnitOfWork Begin()
        {
            if (_unitOfWork != null)
                return _unitOfWork;

            return _unitOfWork;
        }

        public IUnitOfWork Begin(TransactionScopeOption option)
        {
            throw new NotImplementedException();
        }
    }
}
