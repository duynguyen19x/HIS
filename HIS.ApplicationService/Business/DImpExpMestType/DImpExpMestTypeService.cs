using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Business.DImpExpMestType;
using HIS.Dtos.Business.Treatment;
using HIS.Dtos.Commons;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.DImpExpMestType
{
    public class DImpExpMestTypeService : BaseSerivce, IDImpExpMestTypeService
    {
        public DImpExpMestTypeService(HISDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public Task<ApiResult<DImpExpMestTypeDto>> CreateOrEdit(DImpExpMestTypeDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<DImpExpMestTypeDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResultList<DImpExpMestTypeDto>> GetAll(GetAllDImpExpMestTypeInput input)
        {
            var result = new ApiResultList<DImpExpMestTypeDto>();

            try
            {
                result.Result = (from t in _dbContext.DImpExpMestTypes
                                 select new DImpExpMestTypeDto()
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

        public Task<ApiResult<DImpExpMestTypeDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
