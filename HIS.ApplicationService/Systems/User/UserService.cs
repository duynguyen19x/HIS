using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Systems.User;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Systems.User
{
    public class UserService : BaseSerivce, IUserService
    {
        public UserService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper) { }

        public Task<ApiResult<SUserDto>> CreateOrEdit(SUserDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<SUserDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResultList<SUserDto>> GetAll(GetAllSUserInput input)
        {
            var result = new ApiResultList<SUserDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SUsers
                                 select new SUserDto()
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

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public Task<ApiResult<SUserDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
