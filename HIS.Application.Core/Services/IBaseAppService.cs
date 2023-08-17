using AutoMapper;
using HIS.EntityFrameworkCore.EntityFrameworkCore;

namespace HIS.Application.Core.Services
{
    public interface IBaseAppService
    {
        HISDbContext Context { get; }
        IMapper Mapper { get; }
    }
}
