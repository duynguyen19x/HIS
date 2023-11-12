using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Dictionaries.AccountBooks;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.AccountBooks
{
    public class AccountBookAppService : BaseCrudAppService<AccountBookDto, Guid, PagedAccountBookInputDto>, IAccountBookAppService
    {
        public AccountBookAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public override Task<ResultDto<AccountBookDto>> Create(AccountBookDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<AccountBookDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task<PagedResultDto<AccountBookDto>> GetAll(PagedAccountBookInputDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<AccountBookDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<AccountBookDto>> Update(AccountBookDto input)
        {
            throw new NotImplementedException();
        }
    }
}
