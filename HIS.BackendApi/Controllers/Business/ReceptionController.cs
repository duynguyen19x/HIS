using HIS.ApplicationService.Business.Receptions;
using HIS.Dtos.Business.Receptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceptionController : BaseCrudController<IReceptionAppService, ReceptionDto, Guid, GetAllReceptionInput>
    {
        public ReceptionController(IReceptionAppService appService) 
            : base(appService)
        {
        }
    }
}
