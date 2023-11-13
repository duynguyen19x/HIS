using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Application.Core.Utils;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.AccountingBooks;
using HIS.Dtos.Dictionaries.AccountingBookUser;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Systems;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Migrations;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.AccountBooks
{
    public class AccountingBookAppService : BaseCrudAppService<AccountingBookDto, Guid, PagedAccountBookInputDto>, IAccountingBookAppService
    {
        public AccountingBookAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<AccountingBookDto>> Create(AccountingBookDto input)
        {
            var result = new ResultDto<AccountingBookDto>();
            using (var transaction  = BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var accountBook = ObjectMapper.Map<AccountingBook>(input);
                    accountBook.CreatedDate = DateTime.Now;
                    accountBook.CreatedBy = SessionExtensions.Login?.Id;
                    Context.AccountingBooks.Add(accountBook);
                    await SaveChangesAsync();

                    foreach (var dto in input.AccountingBookUsers)
                    {
                        dto.Id = Guid.NewGuid();
                        dto.AccountingBookId = accountBook.Id;
                        var accountingBookBelongUser = ObjectMapper.Map<AccountingBookUser>(dto);
                        Context.AccountingBookUsers.Add(accountingBookBelongUser);
                        await SaveChangesAsync();
                    }    
                    
                    result.IsSucceeded = true;
                    result.Item = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async override Task<ResultDto<AccountingBookDto>> Update(AccountingBookDto input)
        {
            var result = new ResultDto<AccountingBookDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    // xóa dữ liệu cũ
                    var delAccountingBookBelongToUsers = Context.AccountingBookUsers.Where(x => x.AccountingBookId == input.Id).ToList();
                    if (delAccountingBookBelongToUsers != null)
                        Context.AccountingBookUsers.RemoveRange(delAccountingBookBelongToUsers);

                    // cập nhật
                    var data = Context.AccountingBooks.SingleOrDefault(x => x.Id == input.Id);
                    var newData = ObjectMapper.Map<AccountingBook>(input);
                    newData.CreatedDate = data.CreatedDate;
                    newData.CreatedBy = data.CreatedBy;
                    newData.ModifiedDate = DateTime.Now;
                    newData.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.AccountingBooks.Add(newData);
                    await SaveChangesAsync();

                    foreach (var dto in input.AccountingBookUsers)
                    {
                        dto.Id = Guid.NewGuid();
                        dto.AccountingBookId = data.Id;
                        var delAccountingBookUser = ObjectMapper.Map<AccountingBookUser>(dto);
                        Context.AccountingBookUsers.Add(delAccountingBookUser);
                        await SaveChangesAsync();
                    }

                    result.IsSucceeded = true;
                    result.Item = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async override Task<ResultDto<AccountingBookDto>> Delete(Guid id)
        {
            var result = new ResultDto<AccountingBookDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    // xóa dữ liệu cũ
                    var delAccountingBookUsers = Context.AccountingBookUsers.Where(x => x.AccountingBookId == id).ToList();
                    if (delAccountingBookUsers != null)
                        Context.AccountingBookUsers.RemoveRange(delAccountingBookUsers);

                    var data = Context.AccountingBooks.SingleOrDefault(x => x.Id == id);
                    Context.AccountingBooks.Remove(data);
                    await SaveChangesAsync();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async override Task<PagedResultDto<AccountingBookDto>> GetAll(PagedAccountBookInputDto input)
        {
            var result = new PagedResultDto<AccountingBookDto>();
            var filter = Context.AccountingBooks.AsQueryable();
            var paged = filter.PageBy(input).ToList();

            result.Items = ObjectMapper.Map<IList<AccountingBookDto>>(paged);
            result.TotalCount = await filter.CountAsync();
            return result;
        }

        public async override Task<ResultDto<AccountingBookDto>> GetById(Guid id)
        {
            var result = new ResultDto<AccountingBookDto>();
            var data = await Context.AccountingBooks.SingleOrDefaultAsync(x => x.Id == id);
            var users = await Context.AccountingBookUsers.Where(x => x.AccountingBookId == id).ToListAsync();
            result.Item = ObjectMapper.Map<AccountingBookDto>(data);
            result.Item.AccountingBookUsers = ObjectMapper.Map<IList<AccountBookUserDto>>(users);
            return result;
        }

        
    }
}
