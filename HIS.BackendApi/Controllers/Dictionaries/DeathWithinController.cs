using HIS.ApplicationService.Dictionaries.DeathWithins;
using HIS.Dtos.Dictionaries.DeathWithins;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeathWithinController : BaseCrudController<IDeathWithinAppService, DeathWithinDto, Guid, GetAllDeathWithinInput>
    {
        public DeathWithinController(IDeathWithinAppService appService) 
            : base(appService)
        {
        }
    }
}
