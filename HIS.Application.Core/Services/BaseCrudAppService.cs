using AutoMapper;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace HIS.Application.Core.Services
{
    public abstract class BaseCrudAppService : BaseAppService, IBaseCrudAppService
    {
        public BaseCrudAppService(HISDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
