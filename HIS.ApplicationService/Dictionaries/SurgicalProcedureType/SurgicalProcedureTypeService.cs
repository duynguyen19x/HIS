using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Services.Dto;
using HIS.Dtos.Dictionaries.SurgicalProcedureType;
using HIS.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.SurgicalProcedureType
{
    public class SurgicalProcedureTypeService : BaseCrudAppService<SSurgicalProcedureTypeDto, int?, GetAllSurgicalProcedureTypeInput>, ISurgicalProcedureTypeService
    {
        public SurgicalProcedureTypeService(HISDbContext dbContext, IMapper mapper) 
            : base(dbContext, mapper)
        {

        }

        public override Task<ResultDto<SSurgicalProcedureTypeDto>> Create(SSurgicalProcedureTypeDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<SSurgicalProcedureTypeDto>> Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public override async Task<PagedResultDto<SSurgicalProcedureTypeDto>> GetAll(GetAllSurgicalProcedureTypeInput input)
        {
            var result = new PagedResultDto<SSurgicalProcedureTypeDto>();

            try
            {
                result.Result = (from r in Context.SurgicalProcedureTypes
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
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public override Task<ResultDto<SSurgicalProcedureTypeDto>> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<SSurgicalProcedureTypeDto>> Update(SSurgicalProcedureTypeDto input)
        {
            throw new NotImplementedException();
        }
    }
}
