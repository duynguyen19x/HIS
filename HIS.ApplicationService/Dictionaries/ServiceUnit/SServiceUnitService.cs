using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ServiceGroup;
using HIS.Dtos.Dictionaries.ServiceUnit;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.ServiceUnit
{
    public class SServiceUnitService : BaseSerivce, ISServiceUnitService
    {
        public SServiceUnitService(HIS_DbContext dbContext, IConfiguration config, IMapper mapper) : base(dbContext, config, mapper)
        {
        }

        public async Task<ApiResult<SServiceUnitDto>> CreateOrEdit(SServiceUnitDto input)
        {
            if (GuidHelper.IsNullOrEmpty(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        private async Task<ApiResult<SServiceUnitDto>> Create(SServiceUnitDto input)
        {
            var result = new ApiResult<SServiceUnitDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = _mapper.Map<SServiceUnit>(input);

                    _dbContext.SServiceUnits.Add(data);
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

        private async Task<ApiResult<SServiceUnitDto>> Update(SServiceUnitDto input)
        {
            var result = new ApiResult<SServiceUnitDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceUnit = _dbContext.SServiceUnits.FirstOrDefault(f => f.Id == input.Id);
                    if (sServiceUnit == null)
                        _mapper.Map(input, sServiceUnit);

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

        public async Task<ApiResult<SServiceUnitDto>> Delete(Guid id)
        {
            var result = new ApiResult<SServiceUnitDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceUnit = _dbContext.SServiceUnits.SingleOrDefault(x => x.Id == id);
                    if (sServiceUnit != null)
                    {
                        _dbContext.SServiceUnits.Remove(sServiceUnit);
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

        public async Task<ApiResultList<SServiceUnitDto>> GetAll(GetAllSServiceUnitInput input)
        {
            var result = new ApiResultList<SServiceUnitDto>();

            try
            {
                result.Result = (from r in _dbContext.SServiceUnits
                                 where (input.InactiveFilter == null || r.Inactive == !input.InactiveFilter)
                                 select new SServiceUnitDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Inactive = r.Inactive,
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

        public async Task<ApiResult<SServiceUnitDto>> GetById(Guid id)
        {
            var result = new ApiResult<SServiceUnitDto>();

            try
            {
                var service = _dbContext.SServiceGroups.FirstOrDefault(s => s.Id == id);
                result.Result = _mapper.Map<SServiceUnitDto>(service);
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
    }
}
