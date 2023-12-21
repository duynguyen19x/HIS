using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Business.ServiceRequests;
using HIS.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Business.Testings
{
    public class TestingService : BaseAppService, ITestingService
    {
        public TestingService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
           : base(dbContext, mapper) { }

        public async Task<PagedResultDto<ServiceRequestDto>> GetAll(GetAllServiceRequestInputDto input)
        {
            var pagedResults = new PagedResultDto<ServiceRequestDto>();

            var serviceRequests = (from serviceRequest in Context.ServiceRequests
                                   select new ServiceRequestDto()
                                   {

                                   }).ToList();

            return await Task.FromResult(pagedResults);
        }
    }
}
