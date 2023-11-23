using HIS.ApplicationService.Dictionaries.Relatives;
using HIS.Dtos.Dictionaries.Relatives;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelativeController : BaseCrudController<IRelativeAppService, RelativeDto, Guid, GetAllRelativeInput>
    {
        public RelativeController(IRelativeAppService appService) 
            : base(appService)
        {
        }
    }
}
