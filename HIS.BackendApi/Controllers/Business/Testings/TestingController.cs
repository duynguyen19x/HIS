using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Business.Testings;
using HIS.Dtos.Business.ServiceRequests;
using Microsoft.AspNetCore.Mvc;

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
    }
}
