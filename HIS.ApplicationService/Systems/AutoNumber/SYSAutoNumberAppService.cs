using AutoMapper;
using HIS.Application.Core.Services;
using HIS.EntityFrameworkCore;

namespace HIS.ApplicationService.Systems.AutoNumber
{
    public class SYSAutoNumberAppService : BaseAppService, ISYSAutoNumberAppService
    {
        public SYSAutoNumberAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public void Get()
        {

        }

        public void Update() 
        { 

        }
    }
}
