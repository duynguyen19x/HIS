using HIS.ApplicationService.Dictionaries.Branch;
using HIS.ApplicationService.Dictionaries.Hospital;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Branch;
using HIS.Dtos.Dictionaries.Hospital;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SHospitalController : ControllerBase
    {
        private readonly ISHospitalService _hospitalService;

        public SHospitalController(ISHospitalService hospitalService)
        {
            _hospitalService = hospitalService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SHospitalDto>> GetAll([FromQuery] GetAllSHospitalInput input)
        {
            return await _hospitalService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SHospitalDto>> GetById(Guid id)
        {
            return await _hospitalService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SHospitalDto>> CreateOrEdit(SHospitalDto input)
        {
            return await _hospitalService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<SHospitalDto>> Delete(Guid id)
        {
            return await _hospitalService.Delete(id);
        }
    }
}
