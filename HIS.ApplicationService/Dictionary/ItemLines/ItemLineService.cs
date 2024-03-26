using HIS.Dtos.Dictionaries.ItemLines;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.Core.Application.Services;
using System.Transactions;

namespace HIS.ApplicationService.Dictionaries.ItemLines
{
    public class ItemLineService : BaseAppService, IItemLineService
    {
        private readonly IRepository<ItemLine, Guid> _itemLineRepository;

        public ItemLineService(IRepository<ItemLine, Guid> itemLineRepository)
        {
            _itemLineRepository = itemLineRepository;
        }

        public virtual async Task<PagedResultDto<ItemLineDto>> GetAll(GetAllItemLineInput input)
        {
            var result = new PagedResultDto<ItemLineDto>();
            try
            {
                result.Result = (from r in _itemLineRepository.GetAll()
                                 select new ItemLineDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Inactive = r.Inactive,
                                     SortOrder = r.SortOrder
                                 })
                                 .WhereIf(!string.IsNullOrEmpty(input.NameFilter), r => r.Name == input.NameFilter)
                                 .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), r => r.Code == input.CodeFilter)
                                 .WhereIf(input.InactiveFilter != null, r => r.Inactive == input.InactiveFilter)
                                 .OrderBy(o => o.SortOrder).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<ItemLineDto>> GetById(Guid id)
        {
            var result = new ResultDto<ItemLineDto>();

            var ItemLine = _itemLineRepository.FirstOrDefault(s => s.Id == id);
            if (ItemLine != null)
            {
                result.Result = ObjectMapper.Map<ItemLineDto>(ItemLine);
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<ItemLineDto>> CreateOrEdit(ItemLineDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public virtual async Task<ResultDto<ItemLineDto>> Create(ItemLineDto input)
        {
            var result = new ResultDto<ItemLineDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<ItemLine>(input);

                    await _itemLineRepository.InsertAsync(entity);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<ItemLineDto>> Update(ItemLineDto input)
        {
            var result = new ResultDto<ItemLineDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _itemLineRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<ItemLineDto>> Delete(Guid id)
        {
            var result = new ResultDto<ItemLineDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _itemLineRepository.Get(id);

                    await _itemLineRepository.DeleteAsync(entity);

                    unitOfWork.Complete();
                    result.Success(null);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        
    }
}
