using AutoMapper;
using HIS.ApplicationService.Dictionary.SurgicalProcedureTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Categories.Services;

namespace HIS.ApplicationService.Dictionary.SurgicalProcedureTypes
{
    public class SurgicalProcedureTypeAppService : BaseAppService, ISurgicalProcedureTypeAppService
    {
        private readonly IBulkRepository<SurgicalProcedureType, int> _surgicalProcedureTypeRepository;

        public SurgicalProcedureTypeAppService(IBulkRepository<SurgicalProcedureType, int> surgicalProcedureTypeRepository) 
        {
            _surgicalProcedureTypeRepository = surgicalProcedureTypeRepository;
        }

        public virtual Task<ResultDto<SSurgicalProcedureTypeDto>> CreateOrEdit(SSurgicalProcedureTypeDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<SSurgicalProcedureTypeDto>> Create(SSurgicalProcedureTypeDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<SSurgicalProcedureTypeDto>> Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<PagedResultDto<SSurgicalProcedureTypeDto>> GetAll(GetAllSurgicalProcedureTypeInput input)
        {
            var result = new PagedResultDto<SSurgicalProcedureTypeDto>();

            try
            {
                result.Result = (from r in _surgicalProcedureTypeRepository.GetAll()
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

        public virtual Task<ResultDto<SSurgicalProcedureTypeDto>> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<SSurgicalProcedureTypeDto>> Update(SSurgicalProcedureTypeDto input)
        {
            throw new NotImplementedException();
        }
    }
}
