using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HIS.Core.Domain.Uow
{
    public class UnitOfWorkOptions
    {
        public TransactionScopeOption? Scope { get; set; }
        public TimeSpan? Timeout { get; set; }
        public IsolationLevel? IsolationLevel { get; set; }
        public TransactionScopeAsyncFlowOption? AsyncFlowOption { get; set; }
    }
}
