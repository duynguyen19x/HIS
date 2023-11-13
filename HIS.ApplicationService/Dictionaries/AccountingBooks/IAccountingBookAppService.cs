using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.AccountingBooks;

namespace HIS.ApplicationService.Dictionaries.AccountBooks
{
    public interface IAccountingBookAppService : IBaseCrudAppService<AccountingBookDto, Guid, PagedAccountBookInputDto>
    {
    }
}
