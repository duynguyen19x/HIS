using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.AccountBooks;

namespace HIS.ApplicationService.Dictionaries.AccountBooks
{
    public interface IAccountBookAppService : IBaseCrudAppService<AccountBookDto, Guid, PagedAccountBookInputDto>
    {
    }
}
