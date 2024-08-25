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

        [HttpGet("GetServiceRequestById")]
        public async Task<ResultDto<ServiceRequestDto>> GetServiceRequestById(Guid serviceRequestId, GenderTypes gender, bool isDetail = true)
        {
            return await _testingService.GetServiceRequestById(serviceRequestId, gender, isDetail);
        }

        [HttpGet("GetServiceRequestDetailByServiceRequestId")]
        public async Task<ListResultDto<ServiceRequestDetailDto>> GetServiceRequestDetailByServiceRequestId(Guid serviceRequestId, GenderTypes genderType, bool isDetail = true)
        {
            return await _testingService.GetServiceRequestDetailByServiceRequestId(serviceRequestId, genderType, isDetail);
        }

        [HttpGet("GetServiceRequestDetailResultByServiceRequestDetailId")]
        public async Task<ListResultDto<ServiceRequestDetailResultDto>> GetServiceRequestDetailResultByServiceRequestDetailId(Guid serviceRequestDataId, GenderTypes genderType)
        {
            return await _testingService.GetServiceRequestDetailResultByServiceRequestDetailId(serviceRequestDataId, genderType);
        }

        [HttpGet("GetServiceRequestDetailResultByServiceRequestId")]
        public async Task<ListResultDto<ServiceRequestDetailResultDto>> GetServiceRequestDetailResultByServiceRequestId(Guid serviceRequestId, GenderTypes genderType)
        {
            return await _testingService.GetServiceRequestDetailResultByServiceRequestId(serviceRequestId, genderType);
        }

        [HttpPost("UpdateTestingStatus")]
        public async Task<ResultDto<ServiceRequestDto>> UpdateTestingStatus(ServiceRequestDto input)
        {
            return await _testingService.UpdateTestingStatus(input);
        }

        [HttpPost("UpdateTestingCancelStatus")]
        public async Task<ResultDto<ServiceRequestDto>> UpdateTestingCancelStatus(ServiceRequestDto input)
        {
            return await _testingService.UpdateTestingCancelStatus(input);
        }
    }
}
