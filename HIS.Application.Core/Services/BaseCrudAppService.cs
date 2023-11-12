using AutoMapper;
using HIS.Application.Core.Services.Dto;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Runtime.InteropServices;

namespace HIS.Application.Core.Services
{
    public abstract class BaseCrudAppService<TEntityDto, TPrimaryKey, TPagedRequestDto> : BaseAppService, IBaseCrudAppService<TEntityDto, TPrimaryKey, TPagedRequestDto>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TPagedRequestDto : IPagedResultRequestDto
    {
        public BaseCrudAppService(HISDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public virtual async Task<ResultDto<TEntityDto>> CreateOrEdit(TEntityDto input)
        {
            TPrimaryKey key = default(TPrimaryKey);
            if (Equals(input.Id, key))
                return await Create(input);
            else
                return await Update(input);
        }

        public abstract Task<ResultDto<TEntityDto>> Create(TEntityDto input);
        public abstract Task<ResultDto<TEntityDto>> Update(TEntityDto input);
        public abstract Task<ResultDto<TEntityDto>> Delete(TPrimaryKey id);
        public abstract Task<PagedResultDto<TEntityDto>> GetAll(TPagedRequestDto input);
        public abstract Task<ResultDto<TEntityDto>> GetById(TPrimaryKey id);
    }

    public abstract class BaseCrudAppService<TEntityDto, TPagedRequestDto> : BaseCrudAppService<TEntityDto, Guid, TPagedRequestDto>
        where TEntityDto : IEntityDto<Guid>
        where TPagedRequestDto : IPagedResultRequestDto
    {
        public BaseCrudAppService(HISDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }    
}
