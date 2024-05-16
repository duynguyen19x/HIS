using HIS.ApplicationService.Business.MedicalRecords;
using HIS.ApplicationService.Business.Orders;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalRecordController : ControllerBase
    {
        private readonly IMedicalRecordAppService _medicalRecordAppService;

        public MedicalRecordController(IMedicalRecordAppService medicalRecordAppService)
        {
            _medicalRecordAppService = medicalRecordAppService;
        }


    }
}
