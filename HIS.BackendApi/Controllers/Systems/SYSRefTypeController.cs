using HIS.ApplicationService.Systems.RefType;
using HIS.Dtos.Systems;
using HIS.Dtos.Systems.RefType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Systems
{
    [Route("api/[controller]")]
    [ApiController]
    public class SYSRefTypeController : BaseCrudController<ISYSRefTypeAppService, SYSRefTypeDto, int, GetAllSYSRefTypeInputDto>
    {
        public SYSRefTypeController(ISYSRefTypeAppService appService) 
            : base(appService)
        {
        }
    }
}
