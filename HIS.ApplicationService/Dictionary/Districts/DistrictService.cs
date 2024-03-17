using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.District;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.ApplicationService.Dictionaries.Districts
{
    public class DistrictService : BaseCrudAppService<DistrictDto, Guid?, GetAllDistrictInput>, IDistrictService
    {
        public DistrictService(HISDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {

        }

        public override async Task<ResultDto<DistrictDto>> Create(DistrictDto input)
        {
            var result = new ResultDto<DistrictDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<DIDistrict>(input);
                    Context.Districts.Add(data);
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

        public override async Task<ResultDto<DistrictDto>> Update(DistrictDto input)
        {
            var result = new ResultDto<DistrictDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = ObjectMapper.Map<DIDistrict>(input);
                    Context.Districts.Update(data);
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

        public override async Task<ResultDto<DistrictDto>> Delete(Guid? id)
        {
            var result = new ResultDto<DistrictDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var job = Context.Districts.SingleOrDefault(x => x.Id == id);
                    if (job != null)
                    {
                        Context.Districts.Remove(job);
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

        public override async Task<PagedResultDto<DistrictDto>> GetAll(GetAllDistrictInput input)
        {
            var result = new PagedResultDto<DistrictDto>();
            try
            {
                result.IsSucceeded = true;
                result.Result = (from r in Context.Districts
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new DistrictDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
                                     Inactive = r.Inactive
                                 }).OrderBy(o => o.Code).ToList();
                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<DistrictDto>> GetById(Guid? id)
        {
            var result = new ResultDto<DistrictDto>();

            var data = Context.Districts.SingleOrDefault(s => s.Id == id);
            if (data != null)
            {
                result.IsSucceeded = true;
                result.Result = ObjectMapper.Map<DistrictDto>(data); 
            }

            return await Task.FromResult(result);
        }
    }
}
