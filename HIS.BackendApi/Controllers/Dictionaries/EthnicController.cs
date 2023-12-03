using HIS.ApplicationService.Dictionaries.Ethnics;
using HIS.Dtos.Dictionaries.Ethnics;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class EthnicController : BaseCrudController<IEthnicAppService, EthnicDto, Guid, GetAllEthnicInputDto>
    {
        public EthnicController(IEthnicAppService appService) 
            : base(appService)
        {
        }
    }
}
