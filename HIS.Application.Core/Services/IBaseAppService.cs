using AutoMapper;
using HIS.EntityFrameworkCore;

namespace HIS.Application.Core.Services
{
    public interface IBaseAppService
    {
        HISDbContext Context { get; }
        IMapper ObjectMapper { get; set; }
    }
}
