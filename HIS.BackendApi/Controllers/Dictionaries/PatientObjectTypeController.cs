using HIS.ApplicationService.Dictionaries.PatientObjectTypes;
using HIS.Dtos.Dictionaries.PatientObjectTypes;
using HIS.Dtos.Dictionaries.ReceptionObjectTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientObjectTypeController : BaseCrudController<IPatientObjectTypeAppService, PatientObjectTypeDto, int, GetAllPatientObjectTypeInput>
    {
        public PatientObjectTypeController(IPatientObjectTypeAppService appService) 
            : base(appService)
        {
        }
    }
}
