using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.SurgicalProcedureType;
using HIS.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.SurgicalProcedureType
{
    public class SurgicalProcedureTypeService : BaseSerivce, ISurgicalProcedureTypeService
    {
        public SurgicalProcedureTypeService(HISDbContext dbContext, IConfiguration config) : base(dbContext, config)
        {

        }

        public Task<ApiResult<SSurgicalProcedureTypeDto>> CreateOrEdit(SSurgicalProcedureTypeDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<SSurgicalProcedureTypeDto>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResultList<SSurgicalProcedureTypeDto>> GetAll(GetAllSurgicalProcedureTypeInput input)
        {
            var result = new ApiResultList<SSurgicalProcedureTypeDto>();

            try
            {
                result.Result = (from r in _dbContext.SurgicalProcedureTypes
                                 select new SSurgicalProcedureTypeDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     SortOrder = r.SortOrder,
                                 }).OrderBy(o => o.SortOrder).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public Task<ApiResult<SSurgicalProcedureTypeDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
