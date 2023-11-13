using HIS.ApplicationService.Dictionaries.AccountBooks;
using HIS.Dtos.Dictionaries.AccountingBooks;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountBookController : BaseCrudController<IAccountingBookAppService, AccountingBookDto, Guid, PagedAccountBookInputDto>
    {
        public AccountBookController(IAccountingBookAppService appService) 
            : base(appService)
        {
        }
    }
}
