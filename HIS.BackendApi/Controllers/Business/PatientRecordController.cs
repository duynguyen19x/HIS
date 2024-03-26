using HIS.ApplicationService.Business.PatientRecords;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientRecordController : ControllerBase
    {
        public PatientRecordController(IPatientRecordAppService appService) 
        {
        }
    }
}
