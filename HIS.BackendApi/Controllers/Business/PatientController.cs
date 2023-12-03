using HIS.ApplicationService.Business.Patients;
using HIS.Dtos.Business.Patients;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : BaseCrudController<IPatientAppService, PatientDto, Guid, GetAllPatientInputDto>
    {
        public PatientController(IPatientAppService appService) 
            : base(appService)
        {
        }
    }
}
