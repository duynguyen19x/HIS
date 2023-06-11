using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Room;
using HIS.Dtos.Dictionaries.Service;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Models.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Service
{
    public class ServiceService : BaseSerivce, IServiceService
    {
        public ServiceService(HIS_DbContext dbContext, IConfiguration config) : base(dbContext, config)
        {
        }

        public async Task<ApiResult<SServiceDto>> CreateOrEdit(SServiceDto input)
        {
            var result = new ApiResult<SServiceDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = _mapper.Map<SService>(input);
                    _dbContext.SServices.Add(data);
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

        public async Task<ApiResult<SServiceDto>> Delete(Guid id)
        {
            var result = new ApiResult<SServiceDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var service = _dbContext.SServices.SingleOrDefault(x => x.Id == id);
                    if (service != null)
                    {
                        _dbContext.SServices.Remove(service);
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

        public async Task<ApiResultList<SServiceDto>> GetAll(GetAllSServiceInput input)
        {
            var result = new ApiResultList<SServiceDto>();

            try
            {
                result.Result = (from r in _dbContext.SServices
                                 where (input.InactiveFilter == null || r.Inactive == !input.InactiveFilter)
                                 select new SServiceDto()
                                 {
                                     Code = r.Code,
                                     Name = r.Name,
                                     Inactive = r.Inactive,
                                     ServiceGroupId = r.ServiceGroupId,
                                     ServiceUnitId = r.ServiceUnitId,
                                     ServiceTypeId = r.ServiceTypeId,
                                     SurgicalProcedureTypeId = r.SurgicalProcedureTypeId,
                                 }).OrderBy(o => o.Code).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public Task<ApiResult<SServiceDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
