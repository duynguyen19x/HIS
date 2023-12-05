using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
