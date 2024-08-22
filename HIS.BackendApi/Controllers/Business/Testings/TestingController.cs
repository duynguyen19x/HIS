using HIS.ApplicationService.Business.Testings;
using HIS.Dtos.Business.ServiceRequestDatas;
using HIS.Dtos.Business.ServiceRequests;
using HIS.Dtos.Business.ServiceResultDatas;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.Utilities.Enums;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;

namespace HIS.BackendApi.Controllers.Business.Testings
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestingController : ControllerBase
    {
        private readonly ITestingService _testingService;

        public TestingController(ITestingService testingService)
        {
            _testingService = testingService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<ServiceRequestDto>> GetAll([FromQuery] GetAllServiceRequestInputDto input)
        {
            return await _testingService.GetAll(input);
        }

        [HttpGet("GetServiceRequestDataByServiceRequestId")]
        public async Task<ListResultDto<ServiceRequestDetailDto>> GetServiceRequestDataByServiceRequestId(Guid serviceRequestId, GenderTypes genderType, bool isDetail = true)
        {
            return await _testingService.GetServiceRequestDataByServiceRequestId(serviceRequestId, genderType, isDetail);
        }

        [HttpGet("GetServiceResultDataDtoByServiceRequestDataId")]
        public async Task<ListResultDto<ServiceRequestDetailResultDto>> GetServiceResultDataDtoByServiceRequestDataId(Guid serviceRequestDataId, GenderTypes genderType)
        {
            return await _testingService.GetServiceResultDataByServiceRequestDataId(serviceRequestDataId, genderType);
        }

        [HttpGet("GetServiceResultDataByServiceRequestId")]
        public async Task<ListResultDto<ServiceRequestDetailResultDto>> GetServiceResultDataByServiceRequestId(Guid serviceRequestId, GenderTypes genderType)
        {
            return await _testingService.GetServiceResultDataByServiceRequestId(serviceRequestId, genderType);
        }

        [HttpPost("UpdateTestingStatus")]
        public async Task<ResultDto<ServiceRequestDto>> UpdateTestingStatus(ServiceRequestDto input)
        {
            return await _testingService.UpdateTestingStatus(input);
        }
    }
}
