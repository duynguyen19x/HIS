using HIS.ApplicationService.Dictionaries.TreatmentResults;
using HIS.Dtos.Dictionaries.TreatmentResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentResultController : BaseCrudController<ITreatmentResultAppService, TreatmentResultDto, int, GetAllTreatmentResultInput>
    {
        public TreatmentResultController(ITreatmentResultAppService appService) 
            : base(appService)
        {
        }
    }
}
