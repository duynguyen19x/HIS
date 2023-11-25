using HIS.ApplicationService.Dictionaries.PatientTypes;
using HIS.Dtos.Dictionaries.PatientTypes;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientTypeController : BaseCrudController<IPatientTypeAppService, PatientTypeDto, int, GetAllPatientTypeInput>
    {
        public PatientTypeController(IPatientTypeAppService appService) 
            : base(appService)
        {
        }
    }
}
