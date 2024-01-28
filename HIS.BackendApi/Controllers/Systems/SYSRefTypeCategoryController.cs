using HIS.ApplicationService.Systems.RefTypeCategory;
using HIS.Dtos.Systems.RefTypeCategory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Systems
{
    [Route("api/[controller]")]
    [ApiController]
    public class SYSRefTypeCategoryController : ControllerBase
    {
        public SYSRefTypeCategoryController(ISYSRefTypeCategoryAppService appService) 
        {
        }
    }
}
