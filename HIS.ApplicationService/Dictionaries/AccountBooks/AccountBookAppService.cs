using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries;
using HIS.Dtos.Dictionaries.UserAccountBooks;
using HIS.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.AccountBooks
{
    public class AccountBookAppService : BaseCrudAppService<AccountBookDto, Guid, GetAllAccountBookInput>, IAccountBookAppService
    {
        public AccountBookAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public override Task<ResultDto<AccountBookDto>> Create(AccountBookDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<AccountBookDto>> Update(AccountBookDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<AccountBookDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async override Task<PagedResultDto<AccountBookDto>> GetAll(GetAllAccountBookInput input)
        {
            var result = new PagedResultDto<AccountBookDto>();

            var filter = Context.AccountBooks.AsQueryable();
            var data = filter.PageBy(input);
            result.TotalCount = await filter.CountAsync();
            result.Items = ObjectMapper.Map<IList<AccountBookDto>>(data.ToList());

            return result;
        }

        public async override Task<ResultDto<AccountBookDto>> GetById(Guid id)
        {
            var result = new ResultDto<AccountBookDto>();
            try
            {
                var data = Context.AccountBooks.Find(id);
                result.Item = ObjectMapper.Map<AccountBookDto>(data);

                var users = from i in Context.UserAccountBooks
                            join io in Context.Users on i.UserId equals io.Id
                            where i.AccountBookId == id
                            select new UserAccountBookDto()
                            {
                                UserId = i.UserId,
                                UserName = io.UserName,
                                FirstName = io.FirstName,
                                LastName = io.LastName,
                                AccountBookId = i.AccountBookId
                            };
                result.Item.Users = await users.ToListAsync();            
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        
    }
}
