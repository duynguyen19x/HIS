using HIS.Dtos.Systems.RefType;
using HIS.Dtos.Systems;
using Microsoft.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Systems;
using HIS.Core.Domain.Repositories;
using HIS.Core.Services.Dto;
using HIS.Core.Linq.Extensions;
using HIS.Core.Services;

namespace HIS.ApplicationService.Systems.RefType
{
    public class SYSRefTypeAppService : BaseAsyncCrudAppService<SYSRefType, SYSRefTypeDto, int, GetAllSYSRefTypeInputDto>, ISYSRefTypeAppService
    {
        public SYSRefTypeAppService(IRepository<SYSRefType, int> sysRefTypeRepository) 
            : base(sysRefTypeRepository)
        {
        }

        //public override async Task<ResultDto<SYSRefTypeDto>> Create(SYSRefTypeDto input)
        //{
        //    var result = new ResultDto<SYSRefTypeDto>();
        //    using (var unitOfWork = UnitOfWorkManager.Begin())
        //    {
        //        try
        //        {
        //            //input.Id = Context.NewID<SYSRefType>();
        //            var data = ObjectMapper.Map<SYSRefType>(input);
        //            input.Id = await Repository.InsertAndGetIdAsync(data);

        //            unitOfWork.Complete();
        //            result.Result = input;
        //        }
        //        catch (Exception ex)
        //        {
        //            result.Exception(ex);
        //            throw;
        //        }
        //    }
        //    return result;
        //}

        //public override async Task<ResultDto<SYSRefTypeDto>> Update(SYSRefTypeDto input)
        //{
        //    var result = new ResultDto<SYSRefTypeDto>();
        //    using (var unitOfWork = UnitOfWorkManager.Begin())
        //    {
        //        try
        //        {
        //            //input.Id = Context.NewID<SYSRefType>();
        //            var data = ObjectMapper.Map<SYSRefType>(input);
        //            Repository.Update(data);

        //            unitOfWork.Complete();
        //            result.Result = input;
        //        }
        //        catch (Exception ex)
        //        {
        //            result.Exception(ex);
        //            throw;
        //        }
        //    }
        //    return await Task.FromResult(result);
        //}

        //public override async Task<ResultDto<SYSRefTypeDto>> Delete(int id)
        //{
        //    var result = new ResultDto<SYSRefTypeDto>();
        //    using (var unitOfWork = UnitOfWorkManager.Begin())
        //    {
        //        var entity = await Repository.GetAsync(id);
        //        Repository.Delete(entity);
        //    }
        //    return result;
        //}

        //public override async Task<PagedResultDto<SYSRefTypeDto>> GetAll(GetAllSYSRefTypeInputDto input)
        //{
        //    var result = new PagedResultDto<SYSRefTypeDto>();
        //    try
        //    {
        //        var filter = Repository.GetAll()
        //            .WhereIf(!string.IsNullOrEmpty(input.RefTypeNameFilter), x => x.RefTypeName == input.RefTypeNameFilter)
        //            .WhereIf(input.RefTypeCategoryFilter != null, x => x.RefTypeCategoryId == input.RefTypeCategoryFilter);

        //        var paged = filter.OrderBy(s => s.RefTypeCategoryId).ThenBy(t => t.SortOrder).PageBy(input);

        //        result.TotalCount = await filter.CountAsync();
        //        result.Result = ObjectMapper.Map<IList<SYSRefTypeDto>>(paged.ToList());
        //        result.IsSucceeded = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Exception(ex);
        //    }
        //    return result;
        //}

        //public override Task<ResultDto<SYSRefTypeDto>> Get(int id)
        //{
        //    throw new NotImplementedException();
        //}

        
    }
}
