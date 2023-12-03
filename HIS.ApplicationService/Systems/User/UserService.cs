using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Systems.User;
using HIS.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Systems.User
{
    public class UserService : BaseCrudAppService<UserDto, Guid?, GetAllUserInput>, IUserService
    {
        public UserService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, mapper) { }

        public override Task<ResultDto<UserDto>> Create(UserDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<UserDto>> Update(UserDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<UserDto>> Delete(Guid? id)
        {
            throw new NotImplementedException();
        }

        public override async Task<PagedResultDto<UserDto>> GetAll(GetAllUserInput input)
        {
            var result = new PagedResultDto<UserDto>();
            try
            {
                result.IsSucceeded = true;
                result.Items = (from r in Context.Users
                                 select new UserDto()
                                 {
                                     Id = r.Id,
                                     UserName = r.UserName,
                                     Password = r.Password,
                                     PhoneNumber = r.PhoneNumber,
                                     Email = r.Email,
                                     FirstName = r.FirstName,
                                     LastName = r.LastName,
                                     Address = r.Address,
                                     Dob = r.Dob,
                                     UseType = r.UseType,
                                     Status = r.Status,
                                     GenderId = r.GenderId,
                                     ProvinceId = r.ProvinceId,
                                     DistrictId = r.DistrictId,
                                     WardId = r.WardId
                                 }).OrderBy(o => o.UserName).ToList();

                result.TotalCount = result.Items.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public override Task<ResultDto<UserDto>> GetById(Guid? id)
        {
            throw new NotImplementedException();
        }

        
    }
}
