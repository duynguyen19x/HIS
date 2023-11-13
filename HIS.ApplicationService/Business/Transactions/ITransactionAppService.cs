using HIS.Application.Core.Services;
using HIS.Dtos.Business.Transactions;
using HIS.Dtos.Dictionaries.AccountingBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Transactions
{
    public interface ITransactionAppService : IBaseCrudAppService<TransactionDto, Guid, PagedTransactionInputDto>
    {
    }
}
