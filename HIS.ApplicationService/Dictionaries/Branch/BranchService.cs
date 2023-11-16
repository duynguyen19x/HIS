using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Branch;
using HIS.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Branch
{
    public class BranchService : BaseSerivce, IBranchService
    {
        public BranchService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<BranchDto>> CreateOrEdit(BranchDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<BranchDto>> Create(BranchDto input)
        {
            var result = new ApiResult<BranchDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var branch = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.Branch>(input);
                    _dbContext.Branchs.Add(branch);
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

        public async Task<ApiResult<BranchDto>> Update(BranchDto input)
        {
            var result = new ApiResult<BranchDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var branch = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.Branch>(input);
                    _dbContext.Branchs.Update(branch);
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

        public async Task<ApiResult<BranchDto>> Delete(Guid id)
        {
            var result = new ApiResult<BranchDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var branch = _dbContext.Branchs.SingleOrDefault(x => x.Id == id);
                    if (branch != null)
                    {
                        _dbContext.Branchs.Remove(branch);
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

        public async Task<ApiResultList<BranchDto>> GetAll(GetAllBranchInput input)
        {
            var result = new ApiResultList<BranchDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.Branchs
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new BranchDto()
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

        public async Task<ApiResult<BranchDto>> GetById(Guid id)
        {
            var result = new ApiResult<BranchDto>();

            var branch = _dbContext.Branchs.SingleOrDefault(s => s.Id == id);
            if (branch != null)
            {
                result.IsSuccessed = true;
                result.Result = _mapper.Map<BranchDto>(branch);
            }

            return await Task.FromResult(result);
        }
    }
}
