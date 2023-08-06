using AutoMapper;

namespace HIS.Application.Core.Services
{
    public interface IBaseAppService
    {
        IMapper Mapper { get; }
    }
}
