using AutoMapper;
using HIS.EntityFrameworkCore.EntityFrameworkCore;

namespace HIS.Application.Core.Services
{
    public class BaseCrudAppService : BaseAppService, IBaseCrudAppService
    {
        public BaseCrudAppService(HISDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
