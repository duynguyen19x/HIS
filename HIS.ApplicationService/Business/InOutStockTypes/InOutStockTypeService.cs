using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Application.Services;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.ApplicationService.Business.InOutStockTypes.Dto;

namespace HIS.ApplicationService.Business.InOutStockTypes
{
    public class InOutStockTypeService : BaseAppService, IInOutStockTypeService
    {
        private readonly IBulkRepository<InOutStockType, int> _inOutStockTypeRepository;

        public InOutStockTypeService(IBulkRepository<InOutStockType, int> inOutStockTypeRepository)
        {
            _inOutStockTypeRepository = inOutStockTypeRepository;
        }

        public async Task<PagedResultDto<InOutStockTypeDto>> GetAll(GetAllInOutStockTypeInput input)
        {
            var result = new PagedResultDto<InOutStockTypeDto>();

            try
            {
                result.Result = (from t in _inOutStockTypeRepository.GetAll()
                                 select new InOutStockTypeDto()
                                 {
                                     Id = t.Id,
                                     Code = t.Code,
                                     Name = t.Name,
                                     Inactive = t.Inactive
                                 })
                                 .WhereIf(input.InactiveFilter != null, w => w.Inactive == input.InactiveFilter)
                                 .ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
    }
}
