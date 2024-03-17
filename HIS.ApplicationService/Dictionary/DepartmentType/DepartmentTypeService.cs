using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.DepartmentType;
using HIS.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.DepartmentType
{
    public class DepartmentTypeService : BaseCrudAppService<DepartmentTypeDto, int?, GetAllDepartmentTypeInput>, IDepartmentTypeService
    {
        public DepartmentTypeService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, mapper)
        {

        }

        public override async Task<ResultDto<DepartmentTypeDto>> Create(DepartmentTypeDto input)
        {
            var result = new ResultDto<DepartmentTypeDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    //input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.DIDepartmentType>(input);
                    Context.DepartmentTypes.Add(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<DepartmentTypeDto>> Update(DepartmentTypeDto input)
        {
            var result = new ResultDto<DepartmentTypeDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.DIDepartmentType>(input);
                    Context.DepartmentTypes.Update(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<DepartmentTypeDto>> Delete(int? id)
        {
            var result = new ResultDto<DepartmentTypeDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = Context.DepartmentTypes.SingleOrDefault(x => x.Id == id);
                    if (data != null)
                    {
                        Context.DepartmentTypes.Remove(data);
                        await Context.SaveChangesAsync();

                        result.IsSucceeded = true;
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<PagedResultDto<DepartmentTypeDto>> GetAll(GetAllDepartmentTypeInput input)
        {
            var result = new PagedResultDto<DepartmentTypeDto>();
            try
            {
                result.IsSucceeded = true;
                result.Result = (from r in Context.DepartmentTypes
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new DepartmentTypeDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
                                     SortOrder = r.SortOrder,
                                     Inactive = r.Inactive
                                 })
                                 .OrderBy(o => o.SortOrder)
                                 .ThenBy(o => o.Code)
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

        public override async Task<ResultDto<DepartmentTypeDto>> GetById(int? id)
        {
            var result = new ResultDto<DepartmentTypeDto>();
            var data = Context.DepartmentTypes.SingleOrDefault(s => s.Id == id);
            if (data != null)
            {
                result.IsSucceeded = true;
                result.Result = new DepartmentTypeDto()
                {
                    Id = data.Id,
                    Code = data.Code,
                    Name = data.Name,
                    Description = data.Description,
                    SortOrder = data.SortOrder,
                    Inactive = data.Inactive
                };
            }

            return await Task.FromResult(result);
        }
    }
}
