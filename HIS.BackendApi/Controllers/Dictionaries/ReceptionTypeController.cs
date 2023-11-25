using HIS.ApplicationService.Dictionaries.ReceptionTypes;
using HIS.Dtos.Dictionaries.ReceptionTypes;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceptionTypeController : BaseCrudController<IReceptionTypeAppService, ReceptionTypeDto, int, GetAllReceptionTypeInput>
    {
        public ReceptionTypeController(IReceptionTypeAppService appService) 
            : base(appService)
        {
        }
    }
}
