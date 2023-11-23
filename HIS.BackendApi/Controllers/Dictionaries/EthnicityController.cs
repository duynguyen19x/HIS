using HIS.ApplicationService.Dictionaries.Ethnicities;
using HIS.Dtos.Dictionaries.Ethnicities;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class EthnicityController : BaseCrudController<IEthnicityAppService, EthnicityDto, Guid, GetAllEthnicityInput>
    {
        public EthnicityController(IEthnicityAppService appService) 
            : base(appService)
        {
        }
    }
}
