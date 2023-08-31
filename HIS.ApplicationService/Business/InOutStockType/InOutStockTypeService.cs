using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Business.InOutStockTypes;
using HIS.Dtos.Commons;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;

namespace HIS.ApplicationService.Business.InOutStockType
{
    public class InOutStockTypeService : BaseSerivce, IInOutStockTypeService
    {
        public InOutStockTypeService(HISDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public Task<ApiResult<InOutStockTypeDto>> CreateOrEdit(InOutStockTypeDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<InOutStockTypeDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResultList<InOutStockTypeDto>> GetAll(GetAllInOutStockTypeInput input)
        {
            var result = new ApiResultList<InOutStockTypeDto>();

            try
            {
                result.Result = (from t in _dbContext.InOutStockTypes
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
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public Task<ApiResult<InOutStockTypeDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
