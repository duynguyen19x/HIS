using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Application.Core.Utils;
using HIS.Dtos.Business.ServiceRequests;
using HIS.EntityFrameworkCore.EntityFrameworkCore;

namespace HIS.ApplicationService.Business.ServiceRequests
{
    public class ServiceRequestAppService : BaseAppService, IServiceRequestAppService
    {
        public ServiceRequestAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async Task<ResultDto<ServiceRequestDto>> CreateOrEdit(ServiceRequestDto input)
        {
            if (DataHelper.IsNullOrDefault(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        public Task<ResultDto<ServiceRequestDto>> Create(ServiceRequestDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<ServiceRequestDto>> Update(ServiceRequestDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<ServiceRequestDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<ServiceRequestDto>> GetAll(PagedServiceRequestInputDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<ServiceRequestDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
