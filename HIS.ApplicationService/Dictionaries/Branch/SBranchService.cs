using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Branch;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Branch
{
    public class SBranchService : BaseSerivce, ISBranchService
    {
        public SBranchService(HIS_DbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<SBranchDto>> CreateOrEdit(SBranchDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SBranchDto>> Create(SBranchDto input)
        {
            var result = new ApiResult<SBranchDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var branch = _mapper.Map<SBranch>(input);
                    _dbContext.SBranchs.Add(branch);
                    await _dbContext.SaveChangesAsync();

                    result.IsSuccessed = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public async Task<ApiResult<SBranchDto>> Update(SBranchDto input)
        {
            var result = new ApiResult<SBranchDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var branch = _mapper.Map<SBranch>(input);
                    _dbContext.SBranchs.Update(branch);
                    await _dbContext.SaveChangesAsync();

                    result.IsSuccessed = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                { 
                    transaction.Dispose(); 
                }
            }
            return await Task.FromResult(result);
        }

        public async Task<ApiResult<SBranchDto>> Delete(Guid id)
        {
            var result = new ApiResult<SBranchDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var branch = _dbContext.SBranchs.SingleOrDefault(x => x.Id == id);
                    if (branch != null)
                    {
                        _dbContext.SBranchs.Remove(branch);
                        await _dbContext.SaveChangesAsync();
                        result.IsSuccessed = true;

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally 
                { 
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public async Task<ApiResultList<SBranchDto>> GetAll(GetAllSBranchInput input)
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
                                     Address = r.Address,
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

        public async Task<ApiResult<SBranchDto>> GetById(Guid id)
        {
            var result = new ApiResult<SBranchDto>();

            var branch = _dbContext.SBranchs.SingleOrDefault(s => s.Id == id);
            if (branch != null)
            {
                result.IsSuccessed = true;
                result.Result = _mapper.Map<SBranchDto>(branch);
            }

            return await Task.FromResult(result);
        }
    }
}
