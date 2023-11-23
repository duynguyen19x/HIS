using HIS.Application.Core.Services;
using HIS.ApplicationService.Dictionaries.ReceptionObjectTypes;
using HIS.Dtos.Dictionaries.ReceptionObjectTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceptionObjectTypeController : BaseCrudController<IReceptionObjectTypeAppService, ReceptionObjectTypeDto, int, GetAllReceptionObjectTypeInput>
    {
        public ReceptionObjectTypeController(IReceptionObjectTypeAppService appService) 
            : base(appService)
        {
        }
    }
}
