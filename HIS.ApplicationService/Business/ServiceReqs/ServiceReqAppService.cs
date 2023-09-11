using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Application.Core.Utils;
using HIS.Dtos.Business.ServiceReqs;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.ServiceReqs
{
    public class ServiceReqAppService : BaseAppService, IServiceReqAppService
    {
        public ServiceReqAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async Task<ResultDto<ServiceReqDto>> CreateOrEdit(ServiceReqDto input)
        {
            if (DataHelper.IsNullOrDefault(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        public Task<ResultDto<ServiceReqDto>> Create(ServiceReqDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<ServiceReqDto>> Update(ServiceReqDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<ServiceReqDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<ServiceReqDto>> GetAll(PagedServiceReqRequestDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<ServiceReqDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
