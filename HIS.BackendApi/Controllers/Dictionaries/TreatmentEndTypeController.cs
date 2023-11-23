using HIS.ApplicationService.Dictionaries.TreatmentEndTypes;
using HIS.Dtos.Dictionaries.TreatmentEndTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentEndTypeController : BaseCrudController<ITreatmentEndTypeAppService, TreatmentEndTypeDto, int, GetAllTreatmentEndTypeInput>
    {
        public TreatmentEndTypeController(ITreatmentEndTypeAppService appService) 
            : base(appService)
        {
        }
    }
}
