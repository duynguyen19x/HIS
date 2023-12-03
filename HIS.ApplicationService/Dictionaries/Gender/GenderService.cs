using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Dictionaries.Gender;
using HIS.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Gender
{
    public class GenderService : BaseCrudAppService<GenderDto, Guid?, GetAllGenderInput>, IGenderService
    {
        public GenderService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, mapper)
        {

        }

        public override async Task<ResultDto<GenderDto>> Create(GenderDto input)
        {
            var result = new ResultDto<GenderDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.Gender>(input);
                    Context.Genders.Add(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Item = input;

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

        public override async Task<ResultDto<GenderDto>> Update(GenderDto input)
        {
            var result = new ResultDto<GenderDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.Gender>(input);
                    Context.Genders.Update(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Item = input;

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

        public override async Task<ResultDto<GenderDto>> Delete(Guid? id)
        {
            var result = new ResultDto<GenderDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = Context.Genders.SingleOrDefault(x => x.Id == id);
                    if (data != null)
                    {
                        Context.Genders.Remove(data);
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

        public override async Task<PagedResultDto<GenderDto>> GetAll(GetAllGenderInput input)
        {
            var result = new PagedResultDto<GenderDto>();
            try
            {
                result.IsSucceeded = true;
                result.Items = (from r in Context.Genders
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.GenderName == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.GenderCode == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new GenderDto()
                                 {
                                     Id = r.Id,
                                     Code = r.GenderCode,
                                     Name = r.GenderName,
                                     Description = r.Description,
                                     Inactive = r.Inactive,
                                     SortOrder = r.SortOrder
                                 })
                                 .OrderBy(x => x.SortOrder)
                                 .ToList();
                result.TotalCount = result.Items.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<GenderDto>> GetById(Guid? id)
        {
            var result = new ResultDto<GenderDto>();

            var data = Context.Genders.SingleOrDefault(s => s.Id == id);
            if (data != null)
            {
                result.IsSucceeded = true;
                result.Item = new GenderDto()
                {
                    Id = data.Id,
                    Code = data.GenderCode,
                    Name = data.GenderName,
                    Description = data.Description,
                    SortOrder = data.SortOrder,
                    Inactive = data.Inactive
                };
            }

            return await Task.FromResult(result);
        }

    }
}
