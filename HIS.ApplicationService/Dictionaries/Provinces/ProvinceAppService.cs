using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Services.Dto;
using HIS.Dtos.Dictionaries.Province;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.ApplicationService.Dictionaries.Provinces
{
    public class ProvinceAppService : BaseCrudAppService<ProvinceDto, Guid?, GetAllProvinceInput>, IProvinceAppService
    {
        public ProvinceAppService(HISDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public override async Task<ResultDto<ProvinceDto>> Create(ProvinceDto input)
        {
            var result = new ResultDto<ProvinceDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var branch = new EntityFrameworkCore.Entities.Dictionaries.Province()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        ProvinceCode = input.Code,
                        ProvinceName = input.Name,
                        Inactive = input.Inactive
                    };
                    Context.Provinces.Add(branch);
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

        public override async Task<ResultDto<ProvinceDto>> Update(ProvinceDto input)
        {
            var result = new ResultDto<ProvinceDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = ObjectMapper.Map<Province>(input); 
                    Context.Provinces.Update(data);
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

        public override async Task<ResultDto<ProvinceDto>> Delete(Guid? id)
        {
            var result = new ResultDto<ProvinceDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = Context.Provinces.SingleOrDefault(x => x.Id == id);
                    if (data != null)
                    {
                        Context.Provinces.Remove(data);
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

        public override async Task<PagedResultDto<ProvinceDto>> GetAll(GetAllProvinceInput input)
        {
            var result = new PagedResultDto<ProvinceDto>();
            try
            {
                result.IsSucceeded = true;
                result.Result = (from r in Context.Provinces
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.ProvinceName == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.ProvinceCode == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new ProvinceDto()
                                 {
                                     Id = r.Id,
                                     Code = r.ProvinceCode,
                                     Name = r.ProvinceName,
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

        public override async Task<ResultDto<ProvinceDto>> GetById(Guid? id)
        {
            var result = new ResultDto<ProvinceDto>();

            var data = Context.Provinces.SingleOrDefault(s => s.Id == id);
            if (data != null)
            {
                result.IsSucceeded = true;
                result.Result = ObjectMapper.Map<ProvinceDto>(data);
            }

            return await Task.FromResult(result);
        }
    }
}
