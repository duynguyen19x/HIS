using HIS.ApplicationService.Dictionaries.Hospital;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Hospital;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly IHospitalService _hospitalService;

        public HospitalController(IHospitalService hospitalService)
        {
            _hospitalService = hospitalService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<HospitalDto>> GetAll([FromQuery] GetAllHospitalInput input)
        {
            return await _hospitalService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<HospitalDto>> GetById(Guid id)
        {
            return await _hospitalService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<HospitalDto>> CreateOrEdit(HospitalDto input)
        {
            return await _hospitalService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<HospitalDto>> Delete(Guid id)
        {
            return await _hospitalService.Delete(id);
        }
    }
}
