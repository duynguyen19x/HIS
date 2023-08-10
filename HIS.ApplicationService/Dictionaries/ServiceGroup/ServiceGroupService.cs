using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Service;
using HIS.Dtos.Dictionaries.ServiceGroup;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.ServiceGroup
{
    public class ServiceGroupService : BaseSerivce, IServiceGroupService
    {
        public ServiceGroupService(HISDbContext dbContext, IConfiguration config, IMapper mapper) : base(dbContext, config, mapper)
        {
        }

        public async Task<ApiResult<SServiceGroupDto>> CreateOrEdit(SServiceGroupDto input)
        {
            if (GuidHelper.IsNullOrEmpty(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        private async Task<ApiResult<SServiceGroupDto>> Create(SServiceGroupDto input)
        {
            var result = new ApiResult<SServiceGroupDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = _mapper.Map<SServiceGroup>(input);

                    _dbContext.SServiceGroups.Add(data);
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

        private async Task<ApiResult<SServiceGroupDto>> Update(SServiceGroupDto input)
        {
            var result = new ApiResult<SServiceGroupDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceGroup = _dbContext.SServiceGroups.FirstOrDefault(f => f.Id == input.Id);
                    if (sServiceGroup == null)
                        _mapper.Map(input, sServiceGroup);

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

        public async Task<ApiResult<SServiceGroupDto>> Delete(Guid id)
        {
            var result = new ApiResult<SServiceGroupDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var serviceGroup = _dbContext.SServiceGroups.SingleOrDefault(x => x.Id == id);
                    if (serviceGroup != null)
                    {
                        _dbContext.SServiceGroups.Remove(serviceGroup);
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

        public async Task<ApiResultList<SServiceGroupDto>> GetAll(GetAllSServiceGroupInput input)
        {
            var result = new ApiResultList<SServiceGroupDto>();

            try
            {
                result.Result = (from r in _dbContext.SServiceGroups
                                 select new SServiceGroupDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Inactive = r.Inactive,
                                     SortOrder = r.SortOrder,
                                 })
                                 .WhereIf(input.InactiveFilter != null, r => r.Inactive == input.InactiveFilter)
                                 .OrderBy(o => o.SortOrder).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<SServiceGroupDto>> GetById(Guid id)
        {
            var result = new ApiResult<SServiceGroupDto>();

            try
            {
                var service = _dbContext.SServiceGroups.FirstOrDefault(s => s.Id == id);
                result.Result = _mapper.Map<SServiceGroupDto>(service);
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
