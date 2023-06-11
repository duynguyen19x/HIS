using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ServiceGroup;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.ServiceGroup
{
    public class ServiceGroupService : BaseSerivce, IServiceGroupService
    {
        public ServiceGroupService(HIS_DbContext dbContext, IConfiguration config) : base(dbContext, config)
        {
        }


        public Task<ApiResult<SServiceGroupDto>> CreateOrEdit(SServiceGroupDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<SServiceGroupDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResultList<SServiceGroupDto>> GetAll(GetAllSServiceGroupInput input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<SServiceGroupDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
