using HIS.ApplicationService.Business.PatientRecords;
using HIS.Dtos.Business.PatientRecords;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientRecordController : BaseCrudController<IPatientRecordAppService, PatientRecordDto, Guid, GetAllPatientRecordInputDto>
    {
        public PatientRecordController(IPatientRecordAppService appService) 
            : base(appService)
        {
        }
    }
}
