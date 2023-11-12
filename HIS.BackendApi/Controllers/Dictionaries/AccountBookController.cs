using HIS.ApplicationService.Dictionaries.AccountBooks;
using HIS.Dtos.Dictionaries.AccountBooks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountBookController : BaseCrudController<IAccountBookAppService, AccountBookDto, Guid, PagedAccountBookInputDto>
    {
        public AccountBookController(IAccountBookAppService appService) 
            : base(appService)
        {
        }
    }
}
