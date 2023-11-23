using HIS.ApplicationService.Dictionaries.DeathCauses;
using HIS.ApplicationService.Dictionaries.DeathWithins;
using HIS.Dtos.Dictionaries.DeathCauses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeathCauseController : BaseCrudController<IDeathCauseAppService, DeathCauseDto, Guid, GetAllDeathCauseInput>
    {
        public DeathCauseController(IDeathCauseAppService appService) 
            : base(appService)
        {
        }
    }
}
