using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Branch;
using HIS.Dtos.Systems.Role;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Categories.Dictionaries;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Branch
{
    public class BranchService : BaseSerivce<SBranchDto, GetAllSBranchInput>, IBranchService
    {
        public BranchService(HIS_DbContext dbContext, IConfiguration config)
            : base(dbContext, config)
        {

        }


        public override async Task<ApiResult<SBranchDto>> CreateOrEdit(SBranchDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async virtual Task<ApiResult<SBranchDto>> Create(SBranchDto input)
        {
            var result = new ApiResult<SBranchDto>();
            try
            {
                input.Id = Guid.NewGuid();
                var branch = new SBranch()
                {
                    Id = input.Id.GetValueOrDefault(),
                    Code = input.Code,
                    Name = input.Name,
                    Address = input.Address,
                    Description = input.Description,
                    Inactive = input.Inactive
                };
                await _dbContext.SBranchs.AddAsync(branch);
                _dbContext.SaveChanges();

                result.IsSuccessed = true;
                result.Result = input;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }
            return await Task.FromResult(result);
        }

        public async virtual Task<ApiResult<SBranchDto>> Update(SBranchDto input)
        {
            var result = new ApiResult<SBranchDto>();
            try
            {
                var branch = new SBranch()
                {
                    Id = input.Id.GetValueOrDefault(),
                    Code = input.Code,
                    Name = input.Name,
                    Address = input.Address,
                    Description = input.Description,
                    Inactive = input.Inactive
                };
                _dbContext.SBranchs.Update(branch);
                await _dbContext.SaveChangesAsync();

                result.IsSuccessed = true;
                result.Result = input;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }
            return await Task.FromResult(result);
        }

        public override async Task<ApiResult<SBranchDto>> Delete(Guid id)
        {
            var result = new ApiResult<SBranchDto>();
            try
            {
                var branch = _dbContext.SBranchs.SingleOrDefault(x => x.Id == id);
                if (branch != null)
                {
                    _dbContext.SBranchs.Remove(branch);
                    await _dbContext.SaveChangesAsync();
                    result.IsSuccessed = true;
                }
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }
            return await Task.FromResult(result);
        }

        public override async Task<ApiResultList<SBranchDto>> GetAll(GetAllSBranchInput input)
        {
            var result = new ApiResultList<SBranchDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SBranchs
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new SBranchDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
                                     Inactive = r.Inactive
                                 }).ToList();
                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public override async Task<ApiResult<SBranchDto>> GetById(Guid id)
        {
            var result = new ApiResult<SBranchDto>();

            var role = _dbContext.SRoles.SingleOrDefault(s => s.Id == id);
            if (role != null)
            {
                result.Result = new SBranchDto()
                {
                    Id = role.Id,
                    Code = role.Code,
                    Name = role.Name,
                    Description = role.Description,
                    Inactive = role.Inactive
                };
            }

            return await Task.FromResult(result);
        }
    }
}
