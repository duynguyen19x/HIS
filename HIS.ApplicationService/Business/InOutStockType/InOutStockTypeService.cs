using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Services.Dto;
using HIS.Core.Linq.Extensions;
using HIS.Dtos.Business.InOutStockTypes;
using HIS.EntityFrameworkCore;

namespace HIS.ApplicationService.Business.InOutStockType
{
    public class InOutStockTypeService : BaseAppService, IInOutStockTypeService
    {
        public InOutStockTypeService(HISDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public Task<ResultDto<InOutStockTypeDto>> CreateOrEdit(InOutStockTypeDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<InOutStockTypeDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResultDto<InOutStockTypeDto>> GetAll(GetAllInOutStockTypeInput input)
        {
            var result = new PagedResultDto<InOutStockTypeDto>();

            try
            {
                result.Result = (from t in Context.InOutStockTypes
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

        public Task<ResultDto<InOutStockTypeDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
