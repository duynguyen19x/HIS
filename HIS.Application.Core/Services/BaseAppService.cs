using AutoMapper;
using HIS.EntityFrameworkCore.EntityFrameworkCore;

namespace HIS.Application.Core.Services
{
    public abstract class BaseAppService : IBaseAppService
    {
        public virtual HISDbContext Context { get; set; }
        public virtual IMapper Mapper { get; set; }

        public BaseAppService(HISDbContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }
    }
}
